namespace TriviaClient
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.ClockPB = new System.Windows.Forms.PictureBox();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.MainTP = new System.Windows.Forms.ToolTip(this.components);
            this.CorrectAnswersPB = new System.Windows.Forms.PictureBox();
            this.CorrectAnswersLabel = new System.Windows.Forms.Label();
            this.LeaveGameButton = new System.Windows.Forms.Button();
            this.HalfRemoverButton = new System.Windows.Forms.Button();
            this.Label5050 = new System.Windows.Forms.Label();
            this.QuestionNumberLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.HalfRemovedCounterPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClockPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectAnswersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfRemovedCounterPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ClockPB
            // 
            this.ClockPB.BackColor = System.Drawing.Color.Transparent;
            this.ClockPB.Image = global::TriviaClient.Properties.Resources.TimeLeftClock;
            this.ClockPB.Location = new System.Drawing.Point(12, 12);
            this.ClockPB.Name = "ClockPB";
            this.ClockPB.Size = new System.Drawing.Size(100, 100);
            this.ClockPB.TabIndex = 0;
            this.ClockPB.TabStop = false;
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLeftLabel.Location = new System.Drawing.Point(26, 49);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(72, 30);
            this.TimeLeftLabel.TabIndex = 213;
            this.TimeLeftLabel.Text = "0";
            this.TimeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTP.SetToolTip(this.TimeLeftLabel, "Seconds left to answer");
            this.TimeLeftLabel.UseCompatibleTextRendering = true;
            // 
            // CorrectAnswersPB
            // 
            this.CorrectAnswersPB.BackColor = System.Drawing.Color.Transparent;
            this.CorrectAnswersPB.Image = global::TriviaClient.Properties.Resources.test_passed_45px;
            this.CorrectAnswersPB.Location = new System.Drawing.Point(721, 139);
            this.CorrectAnswersPB.Name = "CorrectAnswersPB";
            this.CorrectAnswersPB.Size = new System.Drawing.Size(45, 45);
            this.CorrectAnswersPB.TabIndex = 28;
            this.CorrectAnswersPB.TabStop = false;
            this.MainTP.SetToolTip(this.CorrectAnswersPB, "Score (Correct answered / Total questions)");
            // 
            // CorrectAnswersLabel
            // 
            this.CorrectAnswersLabel.AutoSize = true;
            this.CorrectAnswersLabel.BackColor = System.Drawing.Color.Transparent;
            this.CorrectAnswersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectAnswersLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.CorrectAnswersLabel.Location = new System.Drawing.Point(671, 149);
            this.CorrectAnswersLabel.Name = "CorrectAnswersLabel";
            this.CorrectAnswersLabel.Size = new System.Drawing.Size(42, 20);
            this.CorrectAnswersLabel.TabIndex = 29;
            this.CorrectAnswersLabel.Text = "0 / 0";
            this.MainTP.SetToolTip(this.CorrectAnswersLabel, "Score (Correct answered / Total questions)");
            // 
            // LeaveGameButton
            // 
            this.LeaveGameButton.BackColor = System.Drawing.Color.Transparent;
            this.LeaveGameButton.FlatAppearance.BorderSize = 0;
            this.LeaveGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveGameButton.Image = ((System.Drawing.Image)(resources.GetObject("LeaveGameButton.Image")));
            this.LeaveGameButton.Location = new System.Drawing.Point(721, 12);
            this.LeaveGameButton.Name = "LeaveGameButton";
            this.LeaveGameButton.Size = new System.Drawing.Size(45, 45);
            this.LeaveGameButton.TabIndex = 36;
            this.LeaveGameButton.TabStop = false;
            this.MainTP.SetToolTip(this.LeaveGameButton, "Leave Room");
            this.LeaveGameButton.UseVisualStyleBackColor = false;
            this.LeaveGameButton.Click += new System.EventHandler(this.LeaveGameButton_Click);
            // 
            // HalfRemoverButton
            // 
            this.HalfRemoverButton.BackColor = System.Drawing.Color.Transparent;
            this.HalfRemoverButton.BackgroundImage = global::TriviaClient.Properties.Resources.help_45px;
            this.HalfRemoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HalfRemoverButton.Location = new System.Drawing.Point(26, 151);
            this.HalfRemoverButton.Name = "HalfRemoverButton";
            this.HalfRemoverButton.Size = new System.Drawing.Size(45, 45);
            this.HalfRemoverButton.TabIndex = 214;
            this.MainTP.SetToolTip(this.HalfRemoverButton, "Remove 2 wrong answers (one use per game)");
            this.HalfRemoverButton.UseVisualStyleBackColor = false;
            this.HalfRemoverButton.Click += new System.EventHandler(this.HalfRemoverButton_Click);
            // 
            // Label5050
            // 
            this.Label5050.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5050.AutoSize = true;
            this.Label5050.BackColor = System.Drawing.Color.Transparent;
            this.Label5050.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5050.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Label5050.Location = new System.Drawing.Point(22, 195);
            this.Label5050.Name = "Label5050";
            this.Label5050.Size = new System.Drawing.Size(54, 19);
            this.Label5050.TabIndex = 215;
            this.Label5050.Text = "50/50";
            this.Label5050.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainTP.SetToolTip(this.Label5050, "Remove 2 wrong answers (one use per game)");
            // 
            // QuestionNumberLabel
            // 
            this.QuestionNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNumberLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionNumberLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.QuestionNumberLabel.Location = new System.Drawing.Point(200, 40);
            this.QuestionNumberLabel.Name = "QuestionNumberLabel";
            this.QuestionNumberLabel.Size = new System.Drawing.Size(447, 39);
            this.QuestionNumberLabel.TabIndex = 27;
            this.QuestionNumberLabel.Text = "Question 1/";
            this.QuestionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.QuestionLabel.Location = new System.Drawing.Point(197, 98);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(453, 136);
            this.QuestionLabel.TabIndex = 30;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButton1.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerButton1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AnswerButton1.Location = new System.Drawing.Point(414, 289);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(316, 40);
            this.AnswerButton1.TabIndex = 1;
            this.AnswerButton1.TabStop = false;
            this.AnswerButton1.Text = "Answer1";
            this.AnswerButton1.UseVisualStyleBackColor = false;
            this.AnswerButton1.Click += new System.EventHandler(this.AnswerButton_Clicked);
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButton3.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerButton3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AnswerButton3.Location = new System.Drawing.Point(414, 385);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(316, 40);
            this.AnswerButton3.TabIndex = 3;
            this.AnswerButton3.TabStop = false;
            this.AnswerButton3.Text = "Answer3";
            this.AnswerButton3.UseVisualStyleBackColor = false;
            this.AnswerButton3.Click += new System.EventHandler(this.AnswerButton_Clicked);
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButton2.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerButton2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AnswerButton2.Location = new System.Drawing.Point(64, 289);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(316, 40);
            this.AnswerButton2.TabIndex = 2;
            this.AnswerButton2.TabStop = false;
            this.AnswerButton2.Text = "Answer2";
            this.AnswerButton2.UseVisualStyleBackColor = false;
            this.AnswerButton2.Click += new System.EventHandler(this.AnswerButton_Clicked);
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerButton4.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerButton4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AnswerButton4.Location = new System.Drawing.Point(64, 385);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(316, 40);
            this.AnswerButton4.TabIndex = 4;
            this.AnswerButton4.TabStop = false;
            this.AnswerButton4.Text = "Answer4";
            this.AnswerButton4.UseVisualStyleBackColor = false;
            this.AnswerButton4.Click += new System.EventHandler(this.AnswerButton_Clicked);
            // 
            // HalfRemovedCounterPB
            // 
            this.HalfRemovedCounterPB.BackColor = System.Drawing.Color.Transparent;
            this.HalfRemovedCounterPB.Image = global::TriviaClient.Properties.Resources._1st_20asdpx;
            this.HalfRemovedCounterPB.Location = new System.Drawing.Point(71, 150);
            this.HalfRemovedCounterPB.Name = "HalfRemovedCounterPB";
            this.HalfRemovedCounterPB.Size = new System.Drawing.Size(20, 20);
            this.HalfRemovedCounterPB.TabIndex = 217;
            this.HalfRemovedCounterPB.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.QuestionBG;
            this.ClientSize = new System.Drawing.Size(778, 461);
            this.Controls.Add(this.HalfRemoverButton);
            this.Controls.Add(this.HalfRemovedCounterPB);
            this.Controls.Add(this.Label5050);
            this.Controls.Add(this.LeaveGameButton);
            this.Controls.Add(this.AnswerButton4);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.CorrectAnswersLabel);
            this.Controls.Add(this.CorrectAnswersPB);
            this.Controls.Add(this.QuestionNumberLabel);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.ClockPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "[Trivia] Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClockPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectAnswersPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfRemovedCounterPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ClockPB;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.ToolTip MainTP;
        internal System.Windows.Forms.Label QuestionNumberLabel;
        private System.Windows.Forms.PictureBox CorrectAnswersPB;
        internal System.Windows.Forms.Label CorrectAnswersLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton4;
        private System.Windows.Forms.Button LeaveGameButton;
        private System.Windows.Forms.Button HalfRemoverButton;
        internal System.Windows.Forms.Label Label5050;
        private System.Windows.Forms.PictureBox HalfRemovedCounterPB;
    }
}