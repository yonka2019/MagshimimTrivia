namespace TriviaClient
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.JoinRoomButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateRoomPB = new System.Windows.Forms.PictureBox();
            this.JoinRoomPB = new System.Windows.Forms.PictureBox();
            this.BestScorePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.MainTP = new System.Windows.Forms.ToolTip(this.components);
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CreateRoomPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoinRoomPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestScorePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(31, 48);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(107, 28);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Fira Mono", 10F);
            this.PasswordTB.Location = new System.Drawing.Point(145, 52);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(161, 23);
            this.PasswordTB.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.UsernameLabel.Location = new System.Drawing.Point(25, 5);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(114, 28);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoginButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(113, 95);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(134, 38);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Fira Mono", 10F);
            this.UsernameTB.Location = new System.Drawing.Point(145, 8);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(161, 23);
            this.UsernameTB.TabIndex = 0;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignUpButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpButton.Location = new System.Drawing.Point(131, 141);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(98, 25);
            this.SignUpButton.TabIndex = 4;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateRoomButton.Enabled = false;
            this.CreateRoomButton.FlatAppearance.BorderSize = 0;
            this.CreateRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateRoomButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateRoomButton.Location = new System.Drawing.Point(72, 361);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(139, 38);
            this.CreateRoomButton.TabIndex = 8;
            this.CreateRoomButton.TabStop = false;
            this.CreateRoomButton.Text = "Create Room";
            this.CreateRoomButton.UseVisualStyleBackColor = false;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // JoinRoomButton
            // 
            this.JoinRoomButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.JoinRoomButton.Enabled = false;
            this.JoinRoomButton.FlatAppearance.BorderSize = 0;
            this.JoinRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JoinRoomButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JoinRoomButton.Location = new System.Drawing.Point(72, 405);
            this.JoinRoomButton.Name = "JoinRoomButton";
            this.JoinRoomButton.Size = new System.Drawing.Size(139, 38);
            this.JoinRoomButton.TabIndex = 9;
            this.JoinRoomButton.TabStop = false;
            this.JoinRoomButton.Text = "Join Room";
            this.JoinRoomButton.UseVisualStyleBackColor = false;
            this.JoinRoomButton.Click += new System.EventHandler(this.JoinRoomButton_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatisticsButton.Enabled = false;
            this.StatisticsButton.FlatAppearance.BorderSize = 0;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StatisticsButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticsButton.Location = new System.Drawing.Point(605, 364);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(139, 38);
            this.StatisticsButton.TabIndex = 11;
            this.StatisticsButton.TabStop = false;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = false;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ExitButton.Location = new System.Drawing.Point(605, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(139, 38);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateRoomPB
            // 
            this.CreateRoomPB.BackColor = System.Drawing.Color.Transparent;
            this.CreateRoomPB.Image = global::TriviaClient.Properties.Resources.room_35px;
            this.CreateRoomPB.Location = new System.Drawing.Point(217, 361);
            this.CreateRoomPB.Name = "CreateRoomPB";
            this.CreateRoomPB.Size = new System.Drawing.Size(35, 35);
            this.CreateRoomPB.TabIndex = 13;
            this.CreateRoomPB.TabStop = false;
            // 
            // JoinRoomPB
            // 
            this.JoinRoomPB.BackColor = System.Drawing.Color.Transparent;
            this.JoinRoomPB.Image = global::TriviaClient.Properties.Resources.join_35px;
            this.JoinRoomPB.Location = new System.Drawing.Point(217, 408);
            this.JoinRoomPB.Name = "JoinRoomPB";
            this.JoinRoomPB.Size = new System.Drawing.Size(35, 35);
            this.JoinRoomPB.TabIndex = 14;
            this.JoinRoomPB.TabStop = false;
            // 
            // BestScorePB
            // 
            this.BestScorePB.BackColor = System.Drawing.Color.Transparent;
            this.BestScorePB.Image = global::TriviaClient.Properties.Resources.rating_35px;
            this.BestScorePB.Location = new System.Drawing.Point(564, 361);
            this.BestScorePB.Name = "BestScorePB";
            this.BestScorePB.Size = new System.Drawing.Size(35, 35);
            this.BestScorePB.TabIndex = 15;
            this.BestScorePB.TabStop = false;
            // 
            // ExitPB
            // 
            this.ExitPB.BackColor = System.Drawing.Color.Transparent;
            this.ExitPB.Image = global::TriviaClient.Properties.Resources.exit_35px;
            this.ExitPB.Location = new System.Drawing.Point(564, 408);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(35, 35);
            this.ExitPB.TabIndex = 16;
            this.ExitPB.TabStop = false;
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPasswordButton.FlatAppearance.BorderSize = 0;
            this.ShowPasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordButton.Image")));
            this.ShowPasswordButton.Location = new System.Drawing.Point(312, 51);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(24, 24);
            this.ShowPasswordButton.TabIndex = 2;
            this.ShowPasswordButton.TabStop = false;
            this.MainTP.SetToolTip(this.ShowPasswordButton, "Show password");
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.PasswordTB);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.ShowPasswordButton);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.UsernameTB);
            this.LoginPanel.Controls.Add(this.SignUpButton);
            this.LoginPanel.Location = new System.Drawing.Point(226, 142);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(361, 188);
            this.LoginPanel.TabIndex = 19;
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddQuestionButton.Enabled = false;
            this.AddQuestionButton.FlatAppearance.BorderSize = 0;
            this.AddQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddQuestionButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuestionButton.Location = new System.Drawing.Point(339, 419);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(124, 27);
            this.AddQuestionButton.TabIndex = 20;
            this.AddQuestionButton.TabStop = false;
            this.AddQuestionButton.Text = "Add Question";
            this.AddQuestionButton.UseVisualStyleBackColor = false;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TriviaClient.Properties.Resources.plus_math_35px;
            this.pictureBox1.Location = new System.Drawing.Point(384, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.TriviaNightBG;
            this.ClientSize = new System.Drawing.Size(814, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.BestScorePB);
            this.Controls.Add(this.JoinRoomPB);
            this.Controls.Add(this.CreateRoomPB);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.JoinRoomButton);
            this.Controls.Add(this.CreateRoomButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Trivia] Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreateRoomPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JoinRoomPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestScorePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Button JoinRoomButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox CreateRoomPB;
        private System.Windows.Forms.PictureBox JoinRoomPB;
        private System.Windows.Forms.PictureBox BestScorePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.ToolTip MainTP;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

