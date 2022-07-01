namespace TriviaClient
{
    partial class CreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoom));
            this.TPQNUM = new System.Windows.Forms.NumericUpDown();
            this.SettingsPB = new System.Windows.Forms.PictureBox();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.PlayersNumberLabel = new System.Windows.Forms.Label();
            this.TimePerQuestionLabel = new System.Windows.Forms.Label();
            this.RoomSettingsLabel = new System.Windows.Forms.Label();
            this.RoomNameTB = new System.Windows.Forms.TextBox();
            this.PlayersNUM = new System.Windows.Forms.NumericUpDown();
            this.QuestionsNUM = new System.Windows.Forms.NumericUpDown();
            this.QuestionsNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TPQNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // TPQNUM
            // 
            this.TPQNUM.Font = new System.Drawing.Font("Fira Mono", 10F);
            this.TPQNUM.Location = new System.Drawing.Point(442, 227);
            this.TPQNUM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TPQNUM.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TPQNUM.Name = "TPQNUM";
            this.TPQNUM.Size = new System.Drawing.Size(60, 23);
            this.TPQNUM.TabIndex = 4;
            this.TPQNUM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // SettingsPB
            // 
            this.SettingsPB.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPB.Image = global::TriviaClient.Properties.Resources.settings_40px;
            this.SettingsPB.Location = new System.Drawing.Point(270, 52);
            this.SettingsPB.Name = "SettingsPB";
            this.SettingsPB.Size = new System.Drawing.Size(48, 40);
            this.SettingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SettingsPB.TabIndex = 8;
            this.SettingsPB.TabStop = false;
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateRoomButton.FlatAppearance.BorderSize = 0;
            this.CreateRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateRoomButton.Font = new System.Drawing.Font("Cambria", 13.3F);
            this.CreateRoomButton.Location = new System.Drawing.Point(348, 272);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(126, 35);
            this.CreateRoomButton.TabIndex = 5;
            this.CreateRoomButton.Text = "Create";
            this.CreateRoomButton.UseVisualStyleBackColor = false;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNameLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.RoomNameLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.RoomNameLabel.Location = new System.Drawing.Point(290, 113);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(146, 28);
            this.RoomNameLabel.TabIndex = 12;
            this.RoomNameLabel.Text = "• Room Name:";
            // 
            // PlayersNumberLabel
            // 
            this.PlayersNumberLabel.AutoSize = true;
            this.PlayersNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayersNumberLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.PlayersNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.PlayersNumberLabel.Location = new System.Drawing.Point(257, 149);
            this.PlayersNumberLabel.Name = "PlayersNumberLabel";
            this.PlayersNumberLabel.Size = new System.Drawing.Size(179, 28);
            this.PlayersNumberLabel.TabIndex = 13;
            this.PlayersNumberLabel.Text = "• Players Number:";
            // 
            // TimePerQuestionLabel
            // 
            this.TimePerQuestionLabel.AutoSize = true;
            this.TimePerQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimePerQuestionLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.TimePerQuestionLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.TimePerQuestionLabel.Location = new System.Drawing.Point(207, 224);
            this.TimePerQuestionLabel.Name = "TimePerQuestionLabel";
            this.TimePerQuestionLabel.Size = new System.Drawing.Size(229, 28);
            this.TimePerQuestionLabel.TabIndex = 14;
            this.TimePerQuestionLabel.Text = "• Time Per Question (s):";
            // 
            // RoomSettingsLabel
            // 
            this.RoomSettingsLabel.AutoSize = true;
            this.RoomSettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomSettingsLabel.Font = new System.Drawing.Font("Open Sans", 27F);
            this.RoomSettingsLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.RoomSettingsLabel.Location = new System.Drawing.Point(324, 44);
            this.RoomSettingsLabel.Name = "RoomSettingsLabel";
            this.RoomSettingsLabel.Size = new System.Drawing.Size(273, 51);
            this.RoomSettingsLabel.TabIndex = 15;
            this.RoomSettingsLabel.Text = "Room Settings:";
            // 
            // RoomNameTB
            // 
            this.RoomNameTB.Font = new System.Drawing.Font("Fira Mono", 10F);
            this.RoomNameTB.Location = new System.Drawing.Point(442, 116);
            this.RoomNameTB.Name = "RoomNameTB";
            this.RoomNameTB.Size = new System.Drawing.Size(160, 23);
            this.RoomNameTB.TabIndex = 1;
            // 
            // PlayersNUM
            // 
            this.PlayersNUM.Font = new System.Drawing.Font("Fira Mono", 10F);
            this.PlayersNUM.Location = new System.Drawing.Point(442, 152);
            this.PlayersNUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlayersNUM.Name = "PlayersNUM";
            this.PlayersNUM.Size = new System.Drawing.Size(60, 23);
            this.PlayersNUM.TabIndex = 2;
            this.PlayersNUM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QuestionsNUM
            // 
            this.QuestionsNUM.Font = new System.Drawing.Font("Fira Mono", 10F);
            this.QuestionsNUM.Location = new System.Drawing.Point(442, 190);
            this.QuestionsNUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuestionsNUM.Name = "QuestionsNUM";
            this.QuestionsNUM.Size = new System.Drawing.Size(60, 23);
            this.QuestionsNUM.TabIndex = 3;
            this.QuestionsNUM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QuestionsNumberLabel
            // 
            this.QuestionsNumberLabel.AutoSize = true;
            this.QuestionsNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsNumberLabel.Font = new System.Drawing.Font("Open Sans", 15F);
            this.QuestionsNumberLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.QuestionsNumberLabel.Location = new System.Drawing.Point(229, 187);
            this.QuestionsNumberLabel.Name = "QuestionsNumberLabel";
            this.QuestionsNumberLabel.Size = new System.Drawing.Size(207, 28);
            this.QuestionsNumberLabel.TabIndex = 18;
            this.QuestionsNumberLabel.Text = "• Questions Number:";
            // 
            // CreateRoom
            // 
            this.AcceptButton = this.CreateRoomButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.QuestionMarkBG_CreateRoom;
            this.ClientSize = new System.Drawing.Size(668, 348);
            this.Controls.Add(this.QuestionsNUM);
            this.Controls.Add(this.QuestionsNumberLabel);
            this.Controls.Add(this.PlayersNUM);
            this.Controls.Add(this.RoomNameTB);
            this.Controls.Add(this.RoomSettingsLabel);
            this.Controls.Add(this.TimePerQuestionLabel);
            this.Controls.Add(this.PlayersNumberLabel);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.CreateRoomButton);
            this.Controls.Add(this.SettingsPB);
            this.Controls.Add(this.TPQNUM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateRoom";
            this.Text = "[Trivia] Create Room";
            ((System.ComponentModel.ISupportInitialize)(this.TPQNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown TPQNUM;
        private System.Windows.Forms.PictureBox SettingsPB;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Label PlayersNumberLabel;
        private System.Windows.Forms.Label TimePerQuestionLabel;
        private System.Windows.Forms.Label RoomSettingsLabel;
        private System.Windows.Forms.TextBox RoomNameTB;
        private System.Windows.Forms.NumericUpDown PlayersNUM;
        private System.Windows.Forms.NumericUpDown QuestionsNUM;
        private System.Windows.Forms.Label QuestionsNumberLabel;
    }
}