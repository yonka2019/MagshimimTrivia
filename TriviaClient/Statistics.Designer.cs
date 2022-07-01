namespace TriviaClient
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.PersonalButton = new System.Windows.Forms.Button();
            this.HighScoresButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BestScorePB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BestScorePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalButton
            // 
            this.PersonalButton.BackColor = System.Drawing.Color.Transparent;
            this.PersonalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PersonalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PersonalButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalButton.ForeColor = System.Drawing.Color.MintCream;
            this.PersonalButton.Location = new System.Drawing.Point(16, 117);
            this.PersonalButton.Name = "PersonalButton";
            this.PersonalButton.Size = new System.Drawing.Size(147, 64);
            this.PersonalButton.TabIndex = 0;
            this.PersonalButton.Text = "Personal";
            this.PersonalButton.UseVisualStyleBackColor = true;
            this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
            // 
            // HighScoresButton
            // 
            this.HighScoresButton.BackColor = System.Drawing.Color.Transparent;
            this.HighScoresButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HighScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HighScoresButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighScoresButton.ForeColor = System.Drawing.Color.MintCream;
            this.HighScoresButton.Location = new System.Drawing.Point(267, 117);
            this.HighScoresButton.Name = "HighScoresButton";
            this.HighScoresButton.Size = new System.Drawing.Size(147, 64);
            this.HighScoresButton.TabIndex = 1;
            this.HighScoresButton.Text = "High Scores";
            this.HighScoresButton.UseVisualStyleBackColor = false;
            this.HighScoresButton.Click += new System.EventHandler(this.HighScoresButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.MintCream;
            this.TitleLabel.Location = new System.Drawing.Point(123, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(184, 35);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Game Statistics";
            // 
            // BestScorePB
            // 
            this.BestScorePB.BackColor = System.Drawing.Color.Transparent;
            this.BestScorePB.Image = global::TriviaClient.Properties.Resources.person_35px;
            this.BestScorePB.Location = new System.Drawing.Point(72, 76);
            this.BestScorePB.Name = "BestScorePB";
            this.BestScorePB.Size = new System.Drawing.Size(35, 35);
            this.BestScorePB.TabIndex = 16;
            this.BestScorePB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TriviaClient.Properties.Resources.leaderboard_35px;
            this.pictureBox1.Location = new System.Drawing.Point(323, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.BrickWall;
            this.ClientSize = new System.Drawing.Size(430, 197);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BestScorePB);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.HighScoresButton);
            this.Controls.Add(this.PersonalButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Statistics";
            this.Text = "[Trivia] Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.BestScorePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonalButton;
        private System.Windows.Forms.Button HighScoresButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox BestScorePB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}