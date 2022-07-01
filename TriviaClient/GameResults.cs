using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TriviaClient
{
    public partial class GameResults : Form
    {
        private string[] statisticsData;
        private const int DATA_UPDATE_DELAY_MS = 500;

        public GameResults()
        {
            InitializeComponent();
            Text += Socket.LoggedUserFormatted; // update form text (title)
            Fonts.Ubuntu.SetFont(MainDGV, WaitingForOthersLabel); // set custom fonts to columms which uses them
        }

        private async void GameResults_Load(object sender, EventArgs e)
        {
            SetDataGridViewStyles();

            object[] results = TriviaGet.GetGameResults();

            while (results == null) // not all players finished game
            {
                await System.Threading.Tasks.Task.Delay(DATA_UPDATE_DELAY_MS);
                results = TriviaGet.GetGameResults();
            }

            WaitingForOthersLabel.Visible = false;
            MainDGV.Visible = true;

            foreach (Dictionary<string, object> result in results)
            {
                statisticsData = new string[] { result["username"].ToString(), string.Format("{0:0.00}", result["score"]), result["correctAnswerCount"].ToString(), result["wrongAnswerCount"].ToString(), string.Format("{0:0.00}", result["averageAnswerTime"]) + "s" };
                MainDGV.Rows.Add(statisticsData);
            }

            MainDGV.Sort(MainDGV.Columns["Score"], System.ComponentModel.ListSortDirection.Descending); // sort table by score
            MainDGV.ClearSelection(); // clear focus (disable)

        }

        /// <summary>
        /// Custom styles for the table ^o^
        /// </summary>
        private void SetDataGridViewStyles()
        {
            MainDGV.BorderStyle = BorderStyle.None;
            MainDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            MainDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            MainDGV.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            MainDGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            MainDGV.BackgroundColor = Color.FromArgb(30, 30, 30);
            MainDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            MainDGV.EnableHeadersVisualStyles = false;

            MainDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MainDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            MainDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}