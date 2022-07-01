using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class HighScores : Form
    {
        private readonly Label[] places = new Label[3];
        private readonly Label[] points = new Label[3];
        public HighScores()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)

            places[0] = FirstPlaceLabel;
            places[1] = SecondPlaceLabel;
            places[2] = ThirdPlaceLabel;

            points[0] = FirstPlacePointsLabel;
            points[1] = SecondPlacePointsLabel;
            points[2] = ThirdPlacePointsLabel;

            // set custom fonts to labels which uses them
            Fonts.OpenSans.SetFont(TitleLabel, FirstPlaceLabel, SecondPlaceLabel, ThirdPlaceLabel);
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            object[] statistics = TriviaGet.GetHighScoresStatistics();

            if (statistics != null)
            {
                int i = 0;
                foreach (Dictionary<string, object> stat in statistics)
                {
                    if (i < 3)
                    {
                        places[i].Text = stat["username"].ToString();
                        points[i].Text = string.Format("{0:0.00}", stat["score"]);
                        i++;
                    }
                }
            }
        }
    }
}