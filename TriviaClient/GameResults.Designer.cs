namespace TriviaClient
{
    partial class GameResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameResults));
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswersCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WrongAnswersCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageAnswerTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingForOthersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDGV
            // 
            this.MainDGV.AllowUserToAddRows = false;
            this.MainDGV.AllowUserToDeleteRows = false;
            this.MainDGV.AllowUserToResizeColumns = false;
            this.MainDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.MainDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MainDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainDGV.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MainDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainDGV.ColumnHeadersHeight = 30;
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Score,
            this.CorrectAnswersCount,
            this.WrongAnswersCount,
            this.AverageAnswerTime});
            this.MainDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDGV.EnableHeadersVisualStyles = false;
            this.MainDGV.Location = new System.Drawing.Point(0, 0);
            this.MainDGV.MultiSelect = false;
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.ReadOnly = true;
            this.MainDGV.RowHeadersVisible = false;
            this.MainDGV.RowHeadersWidth = 35;
            this.MainDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MainDGV.ShowEditingIcon = false;
            this.MainDGV.ShowRowErrors = false;
            this.MainDGV.Size = new System.Drawing.Size(617, 183);
            this.MainDGV.TabIndex = 0;
            this.MainDGV.TabStop = false;
            this.MainDGV.Visible = false;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 12;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Username.Width = 82;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 12;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Score.Width = 71;
            // 
            // CorrectAnswersCount
            // 
            this.CorrectAnswersCount.HeaderText = "Correct Answers";
            this.CorrectAnswersCount.MinimumWidth = 12;
            this.CorrectAnswersCount.Name = "CorrectAnswersCount";
            this.CorrectAnswersCount.ReadOnly = true;
            this.CorrectAnswersCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CorrectAnswersCount.Width = 142;
            // 
            // WrongAnswersCount
            // 
            this.WrongAnswersCount.HeaderText = "Wrong Answers";
            this.WrongAnswersCount.MinimumWidth = 12;
            this.WrongAnswersCount.Name = "WrongAnswersCount";
            this.WrongAnswersCount.ReadOnly = true;
            this.WrongAnswersCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WrongAnswersCount.Width = 137;
            // 
            // AverageAnswerTime
            // 
            this.AverageAnswerTime.HeaderText = "Average Answer Time";
            this.AverageAnswerTime.MinimumWidth = 12;
            this.AverageAnswerTime.Name = "AverageAnswerTime";
            this.AverageAnswerTime.ReadOnly = true;
            this.AverageAnswerTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AverageAnswerTime.Width = 182;
            // 
            // WaitingForOthersLabel
            // 
            this.WaitingForOthersLabel.AutoSize = true;
            this.WaitingForOthersLabel.BackColor = System.Drawing.Color.Transparent;
            this.WaitingForOthersLabel.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaitingForOthersLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.WaitingForOthersLabel.Location = new System.Drawing.Point(87, 70);
            this.WaitingForOthersLabel.Name = "WaitingForOthersLabel";
            this.WaitingForOthersLabel.Size = new System.Drawing.Size(443, 42);
            this.WaitingForOthersLabel.TabIndex = 17;
            this.WaitingForOthersLabel.Text = "Waiting for all players to finish..";
            // 
            // GameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.BrickWall;
            this.ClientSize = new System.Drawing.Size(617, 183);
            this.Controls.Add(this.WaitingForOthersLabel);
            this.Controls.Add(this.MainDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Trivia] Game Results";
            this.Load += new System.EventHandler(this.GameResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WrongAnswersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageAnswerTime;
        private System.Windows.Forms.Label WaitingForOthersLabel;
    }
}