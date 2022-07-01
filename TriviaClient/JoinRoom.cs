using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class JoinRoom : Form
    {
        private int selectedRoomId;
        public JoinRoom()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(UsersListBox, RoomsListBox);
        }

        private void JoinRoom_Load(object sender, EventArgs e)
        {
            AutoDataUpdater.AutoRefreshData(this);
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (!Program.UserFilled(Controls))
            {
                MessageBox.Show("You must select some room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isGameAlreadyRunning = TriviaGet.IsRoomActive(RoomsListBox.SelectedItem.ToString());
            if (isGameAlreadyRunning)
            {
                string sendJoinMsg = TriviaProtocol.JoinRoom(selectedRoomId);
                Socket.SendMsg(sendJoinMsg);

                string recvJoinMsg = Socket.RecvMsgByResponse((int)TriviaResponse.JOIN_ROOM);
                if (recvJoinMsg != null)
                {
                    AutoDataUpdater.StopAutoRefreshData();

                    MessageBox.Show($"Successfuly joined to room: {RoomsListBox.SelectedItem}", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WaitingForGame waitingForGame = new WaitingForGame(RoomsListBox.SelectedItem.ToString(), false);
                    Hide();
                    waitingForGame.ShowDialog();
                    Close();
                }
            }
            else
                MessageBox.Show("The game is already running in this room", "Can't Join", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoomsListBox.SelectedItem != null)
            {
                UsersListBox.Items.Clear(); // clear current list

                string selectedRoom = RoomsListBox.SelectedItem.ToString();

                selectedRoomId = TriviaGet.GetRoomId(TriviaGet.GetRooms(), selectedRoom);
                object[] players = TriviaGet.GetUsersInRoom(selectedRoomId);

                foreach (string player in players)
                {
                    UsersListBox.Items.Add(player);
                }
            }
        }

        private void JoinRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoDataUpdater.StopAutoRefreshData();
        }
    }
}
