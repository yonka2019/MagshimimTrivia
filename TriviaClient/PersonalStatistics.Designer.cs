namespace TriviaClient
{
    partial class PersonalStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalStatistics));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CAnswersLabel = new System.Windows.Forms.Label();
            this.WAnswersLabel = new System.Windows.Forms.Label();
            this.AVGTimeLabel = new System.Windows.Forms.Label();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Open Sans", 17F);
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsernameLabel.Location = new System.Drawing.Point(83, 13);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(138, 33);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "USERNAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TriviaClient.Properties.Resources.Done2_35px;
            this.pictureBox1.Location = new System.Drawing.Point(52, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox1, "Correct answers");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TriviaClient.Properties.Resources.timer_35px;
            this.pictureBox2.Location = new System.Drawing.Point(52, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox2, "Average answer time");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TriviaClient.Properties.Resources.Close_35px;
            this.pictureBox3.Location = new System.Drawing.Point(52, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox3, "Wrong answers");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::TriviaClient.Properties.Resources.person_35px;
            this.pictureBox4.Location = new System.Drawing.Point(42, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox4, "Personal statistics of");
            // 
            // CAnswersLabel
            // 
            this.CAnswersLabel.AutoSize = true;
            this.CAnswersLabel.BackColor = System.Drawing.Color.Transparent;
            this.CAnswersLabel.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CAnswersLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.CAnswersLabel.Location = new System.Drawing.Point(93, 72);
            this.CAnswersLabel.Name = "CAnswersLabel";
            this.CAnswersLabel.Size = new System.Drawing.Size(63, 24);
            this.CAnswersLabel.TabIndex = 5;
            this.CAnswersLabel.Text = "label1";
            // 
            // WAnswersLabel
            // 
            this.WAnswersLabel.AutoSize = true;
            this.WAnswersLabel.BackColor = System.Drawing.Color.Transparent;
            this.WAnswersLabel.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WAnswersLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.WAnswersLabel.Location = new System.Drawing.Point(93, 119);
            this.WAnswersLabel.Name = "WAnswersLabel";
            this.WAnswersLabel.Size = new System.Drawing.Size(63, 24);
            this.WAnswersLabel.TabIndex = 6;
            this.WAnswersLabel.Text = "label2";
            // 
            // AVGTimeLabel
            // 
            this.AVGTimeLabel.AutoSize = true;
            this.AVGTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AVGTimeLabel.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AVGTimeLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.AVGTimeLabel.Location = new System.Drawing.Point(93, 166);
            this.AVGTimeLabel.Name = "AVGTimeLabel";
            this.AVGTimeLabel.Size = new System.Drawing.Size(63, 24);
            this.AVGTimeLabel.TabIndex = 7;
            this.AVGTimeLabel.Text = "label3";
            // 
            // PersonalStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.BrickWall;
            this.ClientSize = new System.Drawing.Size(262, 210);
            this.Controls.Add(this.AVGTimeLabel);
            this.Controls.Add(this.WAnswersLabel);
            this.Controls.Add(this.CAnswersLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Trivia] Statistics";
            this.Load += new System.EventHandler(this.PersonalStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label CAnswersLabel;
        private System.Windows.Forms.Label WAnswersLabel;
        private System.Windows.Forms.Label AVGTimeLabel;
        private System.Windows.Forms.ToolTip MainToolTip;
    }
}