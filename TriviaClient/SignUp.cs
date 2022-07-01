using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(UsernameLabel, EmailLabel, PasswordLabel, AddressLabel, PhoneNumberLabel, BirthDateLabel);
            Fonts.Ubuntu.SetFont(UsernameTB, EmailTB, PasswordTB, AddressTB, PhoneNumberTB, BirthDateDTP);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!Program.UserFilled(Controls))
            {
                MessageBox.Show("You must fill all fields to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sendSignUpMsg = TriviaProtocol.SignIn(UsernameTB.Text, PasswordTB.Text, EmailTB.Text, AddressTB.Text, PhoneNumberTB.Text, BirthDateDTP.Text);
            Socket.SendMsg(sendSignUpMsg);

            string recvSignUpMsg = Socket.RecvMsgByResponse((int)TriviaResponse.SIGNUP);
            if (recvSignUpMsg != null)
            {
                MessageBox.Show("Successfully signed up", "Server Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
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
    }
}
