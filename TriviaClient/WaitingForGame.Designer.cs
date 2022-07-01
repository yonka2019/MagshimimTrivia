namespace TriviaClient
{
    partial class WaitingForGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingForGame));
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.CloseRoomButton = new System.Windows.Forms.Button();
            this.LeaveRoomButton = new System.Windows.Forms.Button();
            this.RoomsListGP = new System.Windows.Forms.GroupBox();
            this.MaxUsersPB = new System.Windows.Forms.PictureBox();
            this.TimePerQuestionPB = new System.Windows.Forms.PictureBox();
            this.QuestionsNumPB = new System.Windows.Forms.PictureBox();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UsersLabel = new System.Windows.Forms.Label();
            this.TimePerQuestionLabel = new System.Windows.Forms.Label();
            this.QuestionsNumLabel = new System.Windows.Forms.Label();
            this.RoomsListGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUsersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePerQuestionPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsNumPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectedLabel.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectedLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.ConnectedLabel.Location = new System.Drawing.Point(261, 32);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(394, 42);
            this.ConnectedLabel.TabIndex = 16;
            this.ConnectedLabel.Text = "You are connected to room:";
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNameLabel.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.RoomNameLabel.Location = new System.Drawing.Point(310, 74);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(297, 46);
            this.RoomNameLabel.TabIndex = 17;
            this.RoomNameLabel.Text = "Test name";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersListBox
            // 
            this.UsersListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsersListBox.Font = new System.Drawing.Font("Open Sans", 13F);
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 24;
            this.UsersListBox.Location = new System.Drawing.Point(20, 19);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UsersListBox.Size = new System.Drawing.Size(260, 196);
            this.UsersListBox.TabIndex = 18;
            this.UsersListBox.TabStop = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartGameButton.FlatAppearance.BorderSize = 0;
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartGameButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.Location = new System.Drawing.Point(252, 387);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(139, 38);
            this.StartGameButton.TabIndex = 3;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // CloseRoomButton
            // 
            this.CloseRoomButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CloseRoomButton.FlatAppearance.BorderSize = 0;
            this.CloseRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CloseRoomButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseRoomButton.Location = new System.Drawing.Point(554, 387);
            this.CloseRoomButton.Name = "CloseRoomButton";
            this.CloseRoomButton.Size = new System.Drawing.Size(139, 38);
            this.CloseRoomButton.TabIndex = 1;
            this.CloseRoomButton.Text = "Close Room";
            this.CloseRoomButton.UseVisualStyleBackColor = false;
            this.CloseRoomButton.Click += new System.EventHandler(this.CloseRoomButton_Click);
            // 
            // LeaveRoomButton
            // 
            this.LeaveRoomButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LeaveRoomButton.FlatAppearance.BorderSize = 0;
            this.LeaveRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LeaveRoomButton.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaveRoomButton.Location = new System.Drawing.Point(402, 387);
            this.LeaveRoomButton.Name = "LeaveRoomButton";
            this.LeaveRoomButton.Size = new System.Drawing.Size(139, 38);
            this.LeaveRoomButton.TabIndex = 2;
            this.LeaveRoomButton.Text = "Leave Room";
            this.LeaveRoomButton.UseVisualStyleBackColor = false;
            this.LeaveRoomButton.Click += new System.EventHandler(this.LeaveRoomButton_Click);
            // 
            // RoomsListGP
            // 
            this.RoomsListGP.BackColor = System.Drawing.Color.Transparent;
            this.RoomsListGP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoomsListGP.Controls.Add(this.UsersListBox);
            this.RoomsListGP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsListGP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RoomsListGP.Location = new System.Drawing.Point(323, 133);
            this.RoomsListGP.Name = "RoomsListGP";
            this.RoomsListGP.Size = new System.Drawing.Size(297, 229);
            this.RoomsListGP.TabIndex = 22;
            this.RoomsListGP.TabStop = false;
            this.RoomsListGP.Text = "Users List";
            // 
            // MaxUsersPB
            // 
            this.MaxUsersPB.BackColor = System.Drawing.Color.Transparent;
            this.MaxUsersPB.Image = global::TriviaClient.Properties.Resources.users_35px;
            this.MaxUsersPB.Location = new System.Drawing.Point(646, 142);
            this.MaxUsersPB.Name = "MaxUsersPB";
            this.MaxUsersPB.Size = new System.Drawing.Size(35, 35);
            this.MaxUsersPB.TabIndex = 23;
            this.MaxUsersPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.MaxUsersPB, "Players in room");
            // 
            // TimePerQuestionPB
            // 
            this.TimePerQuestionPB.BackColor = System.Drawing.Color.Transparent;
            this.TimePerQuestionPB.Image = global::TriviaClient.Properties.Resources.clock_35px;
            this.TimePerQuestionPB.Location = new System.Drawing.Point(646, 320);
            this.TimePerQuestionPB.Name = "TimePerQuestionPB";
            this.TimePerQuestionPB.Size = new System.Drawing.Size(35, 35);
            this.TimePerQuestionPB.TabIndex = 24;
            this.TimePerQuestionPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.TimePerQuestionPB, "Time per question");
            // 
            // QuestionsNumPB
            // 
            this.QuestionsNumPB.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsNumPB.Image = global::TriviaClient.Properties.Resources.questions_35px;
            this.QuestionsNumPB.Location = new System.Drawing.Point(646, 230);
            this.QuestionsNumPB.Name = "QuestionsNumPB";
            this.QuestionsNumPB.Size = new System.Drawing.Size(35, 35);
            this.QuestionsNumPB.TabIndex = 25;
            this.QuestionsNumPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.QuestionsNumPB, "Questions number");
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsersLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.UsersLabel.Location = new System.Drawing.Point(687, 148);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(42, 23);
            this.UsersLabel.TabIndex = 26;
            this.UsersLabel.Text = "0 / 0";
            // 
            // TimePerQuestionLabel
            // 
            this.TimePerQuestionLabel.AutoSize = true;
            this.TimePerQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimePerQuestionLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePerQuestionLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimePerQuestionLabel.Location = new System.Drawing.Point(687, 326);
            this.TimePerQuestionLabel.Name = "TimePerQuestionLabel";
            this.TimePerQuestionLabel.Size = new System.Drawing.Size(19, 23);
            this.TimePerQuestionLabel.TabIndex = 27;
            this.TimePerQuestionLabel.Text = "0";
            // 
            // QuestionsNumLabel
            // 
            this.QuestionsNumLabel.AutoSize = true;
            this.QuestionsNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsNumLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionsNumLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.QuestionsNumLabel.Location = new System.Drawing.Point(687, 236);
            this.QuestionsNumLabel.Name = "QuestionsNumLabel";
            this.QuestionsNumLabel.Size = new System.Drawing.Size(19, 23);
            this.QuestionsNumLabel.TabIndex = 28;
            this.QuestionsNumLabel.Text = "0";
            // 
            // WaitingForGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.WaitingForGameBG;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.QuestionsNumLabel);
            this.Controls.Add(this.TimePerQuestionLabel);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.QuestionsNumPB);
            this.Controls.Add(this.TimePerQuestionPB);
            this.Controls.Add(this.MaxUsersPB);
            this.Controls.Add(this.RoomsListGP);
            this.Controls.Add(this.LeaveRoomButton);
            this.Controls.Add(this.CloseRoomButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.ConnectedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WaitingForGame";
            this.Text = "[Trivia] Waiting For Game..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WaitingForGame_FormClosing);
            this.Load += new System.EventHandler(this.WaitingForGame_Load);
            this.RoomsListGP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaxUsersPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimePerQuestionPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsNumPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button CloseRoomButton;
        private System.Windows.Forms.GroupBox RoomsListGP;
        private System.Windows.Forms.PictureBox MaxUsersPB;
        private System.Windows.Forms.PictureBox TimePerQuestionPB;
        private System.Windows.Forms.PictureBox QuestionsNumPB;
        private System.Windows.Forms.ToolTip MainToolTip;
        internal System.Windows.Forms.ListBox UsersListBox;
        internal System.Windows.Forms.Label UsersLabel;
        internal System.Windows.Forms.Label TimePerQuestionLabel;
        internal System.Windows.Forms.Label QuestionsNumLabel;
        internal System.Windows.Forms.Button LeaveRoomButton;
    }
}