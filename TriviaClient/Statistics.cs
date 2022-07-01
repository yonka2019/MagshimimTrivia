using System;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(PersonalButton, HighScoresButton, TitleLabel);
        }

        private void PersonalButton_Click(object sender, EventArgs e)
        {
            PersonalStatistics personalStatistics = new PersonalStatistics();
            Hide();
            personalStatistics.ShowDialog();
            Close();
        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            HighScores highScore = new HighScores();
            Hide();
            highScore.ShowDialog();
            Close();
        }
    }
}
