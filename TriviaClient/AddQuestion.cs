using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class AddQuestion : Form
    {
        private readonly CheckBox[] checkBoxes = new CheckBox[4];
        private readonly TextBox[] answers = new TextBox[4];

        public AddQuestion()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.Ubuntu.SetFont(QuestionTB, Answer1TB, Answer2TB, Answer3TB, Answer4TB);

            checkBoxes[0] = CB1;
            checkBoxes[1] = CB2;
            checkBoxes[2] = CB3;
            checkBoxes[3] = CB4;

            answers[0] = Answer1TB;
            answers[1] = Answer2TB;
            answers[2] = Answer3TB;
            answers[3] = Answer4TB;
        }

        private void DisableOthersCB(CheckBox selected)
        {
            foreach (CheckBox cb in checkBoxes)
            {
                if (cb != selected)
                    cb.Checked = false;
            }
        }

        private string GetCorrectAnswer()
        {
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                    return answers[i].Text;
            }
            return null;
        }

        public List<string> GetWrongAnswers()
        {
            List<string> wrongAnswers = new List<string>();

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (!checkBoxes[i].Checked)
                    wrongAnswers.Add(answers[i].Text);
            }
            return wrongAnswers;
        }


        private void AddQuestion_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("To add question write question and 4 answers, check the correct answer and press", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Text.Contains("'") || textBox.Text.Contains("\""))
                        return false;
                }
            }
            return true;
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            if (!Program.UserFilled(Controls))
            {
                MessageBox.Show("You must fill all text boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (GetCorrectAnswer() == null)
            {
                MessageBox.Show("You must selected any correct answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!CheckTextBoxes())
            {
                MessageBox.Show("You can't use \" ' | \" \" sign in the question/answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string correctAnswer = GetCorrectAnswer();
            List<string> wrongAnswers = GetWrongAnswers();

            string addQuestionAddMsg = TriviaProtocol.AddQuestion(QuestionTB.Text, correctAnswer, wrongAnswers[0], wrongAnswers[1], wrongAnswers[2]);
            Socket.SendMsg(addQuestionAddMsg);

            string recvQuestionAdd = Socket.RecvMsgByResponse((int)TriviaResponse.ADD_QUESTION);
            if (recvQuestionAdd != null)
            {
                MessageBox.Show("Question successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void SomeCheckBox_Clicked(object sender, EventArgs e)
        {
            DisableOthersCB((CheckBox)sender);
        }
    }
}
