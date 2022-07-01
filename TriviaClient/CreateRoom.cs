using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(RoomSettingsLabel, RoomNameLabel, PlayersNumberLabel, QuestionsNumberLabel, TimePerQuestionLabel);
            Fonts.FiraMono.SetFont(RoomNameTB, PlayersNUM, QuestionsNUM, TPQNUM);
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            if (!Program.UserFilled(Controls))
            {
                MessageBox.Show("You must fill all fields to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sendCreateRoomMsg = TriviaProtocol.CreateRoom(RoomNameTB.Text, (int)PlayersNUM.Value, (int)QuestionsNUM.Value, (int)TPQNUM.Value);
            Socket.SendMsg(sendCreateRoomMsg);

            string recvCreateRoomMsg = Socket.RecvMsgByResponse((int)TriviaResponse.CREATE_ROOM);
            if (recvCreateRoomMsg != null)
            {
                MessageBox.Show("Room Successfully created", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                WaitingForGame waitingForGame = new WaitingForGame(RoomNameTB.Text, true);
                Hide();
                waitingForGame.ShowDialog();
                Close();
            }
        }
    }
}
