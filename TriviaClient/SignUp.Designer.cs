namespace TriviaClient
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmailTB = new CueTextBox();
            this.PasswordTB = new CueTextBox();
            this.PhoneNumberTB = new CueTextBox();
            this.AddressTB = new CueTextBox();
            this.UsernameTB = new CueTextBox();
            this.BirthDateDTP = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.MainTP = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPasswordButton.FlatAppearance.BorderSize = 0;
            this.ShowPasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordButton.Image")));
            this.ShowPasswordButton.Location = new System.Drawing.Point(408, 122);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(24, 24);
            this.ShowPasswordButton.TabIndex = 3;
            this.ShowPasswordButton.TabStop = false;
            this.MainTP.SetToolTip(this.ShowPasswordButton, "Show password");
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignUpButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpButton.Location = new System.Drawing.Point(178, 306);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(134, 38);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.UsernameLabel.Location = new System.Drawing.Point(87, 28);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(114, 28);
            this.UsernameLabel.TabIndex = 18;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(94, 120);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(107, 28);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.EmailLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.EmailLabel.Location = new System.Drawing.Point(133, 74);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(68, 28);
            this.EmailLabel.TabIndex = 24;
            this.EmailLabel.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.EmailTB);
            this.groupBox1.Controls.Add(this.PasswordTB);
            this.groupBox1.Controls.Add(this.PhoneNumberTB);
            this.groupBox1.Controls.Add(this.AddressTB);
            this.groupBox1.Controls.Add(this.UsernameTB);
            this.groupBox1.Controls.Add(this.BirthDateDTP);
            this.groupBox1.Controls.Add(this.BirthDateLabel);
            this.groupBox1.Controls.Add(this.PhoneNumberLabel);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.ShowPasswordButton);
            this.groupBox1.Controls.Add(this.UsernameLabel);
            this.groupBox1.Controls.Add(this.SignUpButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 362);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign up";
            // 
            // EmailTB
            // 
            this.EmailTB.Cue = "mail@gmail.com";
            this.EmailTB.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTB.Location = new System.Drawing.Point(207, 77);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(192, 22);
            this.EmailTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Cue = "";
            this.PasswordTB.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(207, 123);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(192, 22);
            this.PasswordTB.TabIndex = 2;
            // 
            // PhoneNumberTB
            // 
            this.PhoneNumberTB.Cue = "0XXXXXXXXX";
            this.PhoneNumberTB.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTB.Location = new System.Drawing.Point(207, 215);
            this.PhoneNumberTB.Name = "PhoneNumberTB";
            this.PhoneNumberTB.Size = new System.Drawing.Size(192, 22);
            this.PhoneNumberTB.TabIndex = 5;
            // 
            // AddressTB
            // 
            this.AddressTB.Cue = "(Street, Apt, City)";
            this.AddressTB.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTB.Location = new System.Drawing.Point(207, 169);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(192, 22);
            this.AddressTB.TabIndex = 4;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Cue = "";
            this.UsernameTB.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTB.Location = new System.Drawing.Point(207, 31);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(192, 22);
            this.UsernameTB.TabIndex = 0;
            // 
            // BirthDateDTP
            // 
            this.BirthDateDTP.CustomFormat = "hh";
            this.BirthDateDTP.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateDTP.Location = new System.Drawing.Point(209, 262);
            this.BirthDateDTP.Name = "BirthDateDTP";
            this.BirthDateDTP.Size = new System.Drawing.Size(103, 20);
            this.BirthDateDTP.TabIndex = 6;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.BirthDateLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.BirthDateLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.BirthDateLabel.Location = new System.Drawing.Point(95, 258);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(111, 28);
            this.BirthDateLabel.TabIndex = 30;
            this.BirthDateLabel.Text = "Birth Date:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(48, 212);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(158, 28);
            this.PhoneNumberLabel.TabIndex = 28;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.AddressLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.AddressLabel.Location = new System.Drawing.Point(108, 166);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(93, 28);
            this.AddressLabel.TabIndex = 26;
            this.AddressLabel.Text = "Address:";
            // 
            // SignUp
            // 
            this.AcceptButton = this.SignUpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.BrickWall;
            this.ClientSize = new System.Drawing.Size(515, 386);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "[Trivia] Sign up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.DateTimePicker BirthDateDTP;
        private System.Windows.Forms.ToolTip MainTP;
        private CueTextBox UsernameTB;
        private CueTextBox EmailTB;
        private CueTextBox PhoneNumberTB;
        private CueTextBox AddressTB;
        private CueTextBox PasswordTB;
    }
}