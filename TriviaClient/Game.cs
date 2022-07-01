using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class Game : Form
    {
        private readonly Button[] answerButtons = new Button[4];
        private readonly GameData gameData;

        private int currentQuestionNumber;
        private TriviaQuestion currentQuestion;
        private int correctAnswersNumber;

        private readonly CountDownTimer timer;

        private const int QUESTIONS_TIMEOUT_MS = 1000; // Ms [1000 / 1000 => 1]
        private const string FINISHED_GAME = "finished game";

        private bool halfRemover = true;

        public Game(string questionsNumber, string timePerQuestion)
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.ArcadeClassic.SetFont(TimeLeftLabel);
            Fonts.OpenSans.SetFont(CorrectAnswersLabel, QuestionLabel);

            answerButtons[0] = AnswerButton1;
            answerButtons[1] = AnswerButton2;
            answerButtons[2] = AnswerButton3;
            answerButtons[3] = AnswerButton4;

            gameData = new GameData(questionsNumber, timePerQuestion);
            currentQuestionNumber = 0;

            timer = new CountDownTimer(0, gameData.SecondsPerQuestion);

            timer.TimeChanged += () => TimerTick(timer.TimeLeftSStr);
            timer.CountDownFinished += TimeUp;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            SetQuestion();
        }

        private void AnswerButton_Clicked(object sender, EventArgs e)
        {
            if (timer.IsRunning)  // check if button have not already pressed (double press or something..)
            {
                timer.Pause();

                Button selectedButton = (Button)sender;
                EnableAnswerButtons(false, selectedButton);
                string answer = selectedButton.Text;
                bool correctAnswer = CheckAnswer(answer);

                if (correctAnswer)
                {
                    selectedButton.ForeColor = System.Drawing.Color.Lime;
                    SetCorrectAnswersNumber(correctAnswersNumber + 1);
                }
                else
                {
                    selectedButton.ForeColor = System.Drawing.Color.Red;
                }
                selectedButton.Refresh();
                MoveToNextQuestion();
            }
        }

        private void LeaveGameButton_Click(object sender, EventArgs e)
        {
            string sendLeaveGameMsg = TriviaProtocol.LeaveGame();
            Socket.SendMsg(sendLeaveGameMsg);

            string recvLeaveGameMsg = Socket.RecvMsgByResponse((int)TriviaResponse.LEAVE_GAME);

            if (recvLeaveGameMsg != null)
            {
                TriviaMessage leaveGameMessage = new TriviaMessage(recvLeaveGameMsg);
                if (int.Parse(leaveGameMessage.ToDict()["status"]) == (int)TriviaResponse.SUCCESS)
                {
                    timer.Dispose();

                    Hide();
                    Close();
                }
                else
                    MessageBox.Show("Can't leave game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetQuestion()
        {
            try
            {
                ResetAnswerButtonsColor();
                timer.Reset();

                currentQuestion = new TriviaQuestion(TriviaGet.GetQuestion());
                if (currentQuestion.Question == FINISHED_GAME) // finished game
                {
                    timer.Dispose();

                    GameResults gameResult = new GameResults();
                    Hide();
                    gameResult.ShowDialog();
                    Close();
                }
                else
                {

                    SetCurrentQuestionNumber(currentQuestionNumber + 1);

                    QuestionLabel.Text = currentQuestion.Question;
                    SetAnswers(currentQuestion);
                    TimeLeftLabel.Text = gameData.SecondsPerQuestion.ToString(); // intial timer

                    timer.Start();

                    EnableAnswerButtons(true);
                }
            }
            catch { }
        }

        private void ResetAnswerButtonsColor()
        {
            foreach (Button button in answerButtons)
                button.ForeColor = System.Drawing.Color.LightSkyBlue;
        }

        private async void MoveToNextQuestion()
        {
            await System.Threading.Tasks.Task.Delay(QUESTIONS_TIMEOUT_MS);
            SetQuestion();
        }

        private void TimerTick(string timeLeft)
        {
            TimeLeftLabel.Text = timeLeft;
        }

        private void TimeUp()
        {
            CheckAnswer(null);
            EnableAnswerButtons(false);

            MoveToNextQuestion();
        }

        private void SetAnswers(TriviaQuestion triviaQuestion)
        {
            const int AnswersNumber = 4;

            for (int i = 0; i < AnswersNumber; i++)
            {
                answerButtons[i].Text = triviaQuestion.Answers[i];
            }
        }

        /// <summary>
        /// Disable or enable all buttons instead of the 'correctButton'
        /// </summary>
        /// <param name="toEnable">Enable or disable the buttons</param>
        /// <param name="correctButton">To all buttons, instead of the correct one</param>
        private void EnableAnswerButtons(bool toEnable, Button correctButton = null)
        {
            foreach (Button button in answerButtons)
            {
                if (button != correctButton)
                    button.Enabled = toEnable;
            }
        }

        /// <summary>
        /// checks if all answer buttons enabled
        /// </summary>
        /// <returns>true if all buttons enabled, either, false</returns>
        private bool AllAnswersEnabled()
        {
            foreach (Button button in answerButtons)
            {
                if (!button.Enabled)
                    return false;
            }
            return true;
        }

        private void SetCorrectAnswersNumber(int value)
        {
            CorrectAnswersLabel.Text = $"{value}/{currentQuestionNumber}";
            correctAnswersNumber = value;
        }

        private void SetCurrentQuestionNumber(int value)
        {
            CorrectAnswersLabel.Text = $"{correctAnswersNumber}/{value}";
            currentQuestionNumber = value;
            QuestionNumberLabel.Text = $"Question {value}/{gameData.QuestionsNumber}";
        }

        private bool CheckAnswer(string answer)
        {
            int answerId = currentQuestion.GetAnswerId(answer);

            string sendSubmitAnswerMsg = TriviaProtocol.SubmitAnswer(answerId);
            Socket.SendMsg(sendSubmitAnswerMsg);

            string recvSubmitAnswerMsg = Socket.RecvMsgByResponse((int)TriviaResponse.SUBMIT_ANSWER);
            if (recvSubmitAnswerMsg != null)
            {
                TriviaMessage submitAnswerMessage = new TriviaMessage(recvSubmitAnswerMsg);

                if (int.Parse(submitAnswerMessage.ToDict()["status"]) == (int)TriviaResponse.SUCCESS)
                    return answerId == int.Parse(submitAnswerMessage.ToDict()["correctAnswerId"]); // check if selected question is the right one (comparison of answers indexes)
                else
                    MessageBox.Show("Can't submit the answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void HalfRemoverButton_Click(object sender, EventArgs e)
        {
            int removed = 0;

            if (halfRemover && AllAnswersEnabled())
            {
                halfRemover = false;
                HalfRemoverButton.Enabled = false;
                HalfRemoverButton.Image = Properties.Resources.gray_help_45px; // simulate button disable
                Label5050.ForeColor = System.Drawing.SystemColors.ScrollBar;
                HalfRemovedCounterPB.Image = Properties.Resources.circled_0dh_20px;

                for (int i = 0; i < answerButtons.Length; i++) // 2 wrong answers to disable (50 / 50) 2 left
                {
                    if (answerButtons[i].Text != currentQuestion.CorrectAnswer && removed < 2)
                    {
                        removed++;
                        answerButtons[i].Enabled = false; // disable wrong answers
                    }
                }
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            LeaveGameButton.PerformClick(); // if user closed game => perform 'leave game'
        }
    }

    internal struct GameData
    {
        public int QuestionsNumber, SecondsPerQuestion;
        public GameData(string numberOfQuestions, string timePerQuestion)
        {
            QuestionsNumber = int.Parse(numberOfQuestions);
            SecondsPerQuestion = int.Parse(timePerQuestion.Substring(0, timePerQuestion.Length - 1));
        }
    }
}