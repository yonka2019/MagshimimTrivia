using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(UsernameLabel, PasswordLabel);
            Fonts.FiraMono.SetFont(UsernameTB, PasswordTB);
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            if (MainTP.GetToolTip(ShowPasswordButton) == "Show password")
            {
                MainTP.SetToolTip(ShowPasswordButton, "Hide password");
                PasswordTB.PasswordChar = '\0';
            }
            else
            {
                MainTP.SetToolTip(ShowPasswordButton, "Show password");
                PasswordTB.PasswordChar = '*';
            }
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            CreateRoom createRoom = new CreateRoom();
            Hide();
            createRoom.ShowDialog();
            Show();
        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            JoinRoom joinRoom = new JoinRoom();
            Hide();
            joinRoom.ShowDialog();
            Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            Hide();
            signUp.ShowDialog();
            Show();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            Hide();
            statistics.ShowDialog();
            Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!Program.UserFilled(Controls))
            {
                MessageBox.Show("You must fill all fields to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sendLoginMsg = TriviaProtocol.Login(UsernameTB.Text, PasswordTB.Text);
            Socket.SendMsg(sendLoginMsg);

            string recvLoginMsg = Socket.RecvMsgByResponse((int)TriviaResponse.LOGIN);
            if (recvLoginMsg != null)
            {
                MessageBox.Show("Successfully logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginPanel.Visible = false;

                StatisticsButton.Enabled = true;
                CreateRoomButton.Enabled = true;
                JoinRoomButton.Enabled = true;
                AddQuestionButton.Enabled = true;

                Socket.LoggedUser = UsernameTB.Text;
                Text += Socket.LoggedUserFormatted; // update form text (title)
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitClient();
            Application.Exit();
        }

        private void ExitClient()
        {
            if (Socket.Connected)
            {
                TriviaMessage message = new TriviaMessage((int)TriviaRequest.EXIT_CLIENT, "");

                if (Socket.IsLogged) // if user logged in - log out
                    message.Content = "logout";

                Socket.SendMsg(message.ToString());

                Socket.Connected = false; // logged out
            }
        }
        private void UpdateLoginState()
        {
            if (Socket.IsLogged)
            {
                LoginPanel.Visible = false;

                StatisticsButton.Enabled = true;
                CreateRoomButton.Enabled = true;
                JoinRoomButton.Enabled = true;
                AddQuestionButton.Enabled = true;

                Text += Socket.LoggedUserFormatted; // update form text (title)
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitClient();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            UpdateLoginState();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            Hide();
            addQuestion.ShowDialog();
            Show();
        }
    }
}
