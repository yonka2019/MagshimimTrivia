namespace TriviaClient
{
    partial class JoinRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinRoom));
            this.RoomsListBox = new System.Windows.Forms.ListBox();
            this.RoomsListGP = new System.Windows.Forms.GroupBox();
            this.UsersInRoomGP = new System.Windows.Forms.GroupBox();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.JoinButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomsListGP.SuspendLayout();
            this.UsersInRoomGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomsListBox
            // 
            this.RoomsListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomsListBox.Font = new System.Drawing.Font("Open Sans", 13F);
            this.RoomsListBox.FormattingEnabled = true;
            this.RoomsListBox.ItemHeight = 24;
            this.RoomsListBox.Location = new System.Drawing.Point(21, 18);
            this.RoomsListBox.Name = "RoomsListBox";
            this.RoomsListBox.Size = new System.Drawing.Size(197, 364);
            this.RoomsListBox.TabIndex = 0;
            this.RoomsListBox.TabStop = false;
            this.RoomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // RoomsListGP
            // 
            this.RoomsListGP.BackColor = System.Drawing.Color.Transparent;
            this.RoomsListGP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoomsListGP.Controls.Add(this.RoomsListBox);
            this.RoomsListGP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsListGP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RoomsListGP.Location = new System.Drawing.Point(169, 54);
            this.RoomsListGP.Name = "RoomsListGP";
            this.RoomsListGP.Size = new System.Drawing.Size(243, 405);
            this.RoomsListGP.TabIndex = 2;
            this.RoomsListGP.TabStop = false;
            this.RoomsListGP.Text = "Rooms List";
            // 
            // UsersInRoomGP
            // 
            this.UsersInRoomGP.BackColor = System.Drawing.Color.Transparent;
            this.UsersInRoomGP.Controls.Add(this.UsersListBox);
            this.UsersInRoomGP.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UsersInRoomGP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.UsersInRoomGP.Location = new System.Drawing.Point(503, 54);
            this.UsersInRoomGP.Name = "UsersInRoomGP";
            this.UsersInRoomGP.Size = new System.Drawing.Size(243, 405);
            this.UsersInRoomGP.TabIndex = 3;
            this.UsersInRoomGP.TabStop = false;
            this.UsersInRoomGP.Text = "Users In Room";
            // 
            // UsersListBox
            // 
            this.UsersListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.UsersListBox.Font = new System.Drawing.Font("Open Sans", 13F);
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 24;
            this.UsersListBox.Location = new System.Drawing.Point(21, 18);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UsersListBox.Size = new System.Drawing.Size(197, 364);
            this.UsersListBox.TabIndex = 0;
            this.UsersListBox.TabStop = false;
            // 
            // JoinButton
            // 
            this.JoinButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.JoinButton.FlatAppearance.BorderSize = 0;
            this.JoinButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JoinButton.Font = new System.Drawing.Font("Cambria", 13.5F);
            this.JoinButton.Location = new System.Drawing.Point(396, 470);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(126, 35);
            this.JoinButton.TabIndex = 10;
            this.JoinButton.TabStop = false;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = false;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TriviaClient.Properties.Resources.more_than_50px;
            this.pictureBox1.Location = new System.Drawing.Point(434, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // JoinRoom
            // 
            this.AcceptButton = this.JoinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.QuestionMark2BG_JoinRoom;
            this.ClientSize = new System.Drawing.Size(798, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.UsersInRoomGP);
            this.Controls.Add(this.RoomsListGP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JoinRoom";
            this.Text = "[Trivia] Join Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JoinRoom_FormClosing);
            this.Load += new System.EventHandler(this.JoinRoom_Load);
            this.RoomsListGP.ResumeLayout(false);
            this.UsersInRoomGP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox RoomsListGP;
        private System.Windows.Forms.GroupBox UsersInRoomGP;
        private System.Windows.Forms.Button JoinButton;
        internal System.Windows.Forms.ListBox RoomsListBox;
        internal System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}