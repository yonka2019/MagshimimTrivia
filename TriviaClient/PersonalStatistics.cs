using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class PersonalStatistics : Form
    {
        public PersonalStatistics()
        {
            InitializeComponent();

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(UsernameLabel);
            Fonts.Ubuntu.SetFont(CAnswersLabel, WAnswersLabel, AVGTimeLabel);
        }

        private void PersonalStatistics_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = Socket.LoggedUser;
            object[] statistics = TriviaGet.GetPersonalStatistics();

            CAnswersLabel.Text = statistics[0].ToString();
            WAnswersLabel.Text = statistics[1].ToString();
            AVGTimeLabel.Text = statistics[2].ToString();
        }
    }
}
