using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class WaitingForGame : Form
    {
        private static bool isAdmin;

        public WaitingForGame(string roomName, bool admin)
        {
            InitializeComponent();

            RoomName = roomName;
            RoomNameLabel.Text = roomName;
            IsAdmin = admin;
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(ConnectedLabel, RoomNameLabel, UsersLabel, QuestionsNumLabel, TimePerQuestionLabel, UsersListBox);
            Fonts.Ubuntu.SetFont(RoomNameLabel);
        }

        private void WaitingForGame_Load(object sender, EventArgs e)
        {
            AutoDataUpdater.AutoRefreshData(this);
        }

        public static string RoomName { get; set; }

        private bool IsAdmin
        {
            set
            {
                isAdmin = value;
                if (value)
                    LeaveRoomButton.Visible = false;
                else
                {
                    StartGameButton.Visible = false;
                    CloseRoomButton.Visible = false;
                }
            }
            get => isAdmin;
        }

        private void WaitingForGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoDataUpdater.StopAutoRefreshData();

            if (!IsAdmin)
                LeaveRoomButton.PerformClick(); // simulate leave room
            else
                CloseRoomButton.PerformClick();
        }

        private void LeaveRoomButton_Click(object sender, EventArgs e)
        {
            string sendLeaveRoomMsg = TriviaProtocol.LeaveRoom();
            Socket.SendMsg(sendLeaveRoomMsg);

            string recvLeaveRoomMsg = Socket.RecvMsgByResponse((int)TriviaResponse.LEAVE_ROOM);
            if (recvLeaveRoomMsg != null)
            {
                AutoDataUpdater.StopAutoRefreshData();
                ExitMenu();
            }
        }

        internal void ExitMenu()
        {
            Hide();
            Close();
        }

        private void CloseRoomButton_Click(object sender, EventArgs e)
        {
            string sendCloseRoomMsg = TriviaProtocol.CloseRoom();
            Socket.SendMsg(sendCloseRoomMsg);

            string recvCloseRoomMsg = Socket.RecvMsgByResponse((int)TriviaResponse.CLOSE_ROOM);
            if (recvCloseRoomMsg != null)
            {
                AutoDataUpdater.StopAutoRefreshData();

                MessageBox.Show("Room successfully closed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // return back to main menu
                ExitMenu();
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            string sendStartGameMsg = TriviaProtocol.StartGame();
            Socket.SendMsg(sendStartGameMsg);

            string recvStartGameMsg = Socket.RecvMsgByResponse((int)TriviaResponse.START_GAME);
            if (recvStartGameMsg != null) // success - no errors
            {
                AutoDataUpdater.StopAutoRefreshData();
                StartGameForm(QuestionsNumLabel.Text, TimePerQuestionLabel.Text);
            }
        }

        public void StartGameForm(string questionsNumber, string timePerQuestion)
        {
            Game game = new Game(questionsNumber, timePerQuestion);
            Hide();
            game.ShowDialog();
            Close();
        }
    }
}
