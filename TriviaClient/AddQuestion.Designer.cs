namespace TriviaClient
{
    partial class AddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestion));
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.Answer2TB = new CueTextBox();
            this.Answer4TB = new CueTextBox();
            this.Answer3TB = new CueTextBox();
            this.Answer1TB = new CueTextBox();
            this.QuestionTB = new CueTextBox();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.BackColor = System.Drawing.Color.Transparent;
            this.CB3.Location = new System.Drawing.Point(141, 79);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(15, 14);
            this.CB3.TabIndex = 5;
            this.CB3.TabStop = false;
            this.MainToolTip.SetToolTip(this.CB3, "Correct answer checker");
            this.CB3.UseVisualStyleBackColor = false;
            this.CB3.Click += new System.EventHandler(this.SomeCheckBox_Clicked);
            // 
            // CB4
            // 
            this.CB4.AutoSize = true;
            this.CB4.BackColor = System.Drawing.Color.Transparent;
            this.CB4.Location = new System.Drawing.Point(141, 127);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(15, 14);
            this.CB4.TabIndex = 6;
            this.CB4.TabStop = false;
            this.MainToolTip.SetToolTip(this.CB4, "Correct answer checker");
            this.CB4.UseVisualStyleBackColor = false;
            this.CB4.Click += new System.EventHandler(this.SomeCheckBox_Clicked);
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.BackColor = System.Drawing.Color.Transparent;
            this.CB1.Location = new System.Drawing.Point(266, 79);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(15, 14);
            this.CB1.TabIndex = 7;
            this.CB1.TabStop = false;
            this.MainToolTip.SetToolTip(this.CB1, "Correct answer checker");
            this.CB1.UseVisualStyleBackColor = false;
            this.CB1.Click += new System.EventHandler(this.SomeCheckBox_Clicked);
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.BackColor = System.Drawing.Color.Transparent;
            this.CB2.Location = new System.Drawing.Point(266, 127);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(15, 14);
            this.CB2.TabIndex = 8;
            this.CB2.TabStop = false;
            this.MainToolTip.SetToolTip(this.CB2, "Correct answer checker");
            this.CB2.UseVisualStyleBackColor = false;
            this.CB2.Click += new System.EventHandler(this.SomeCheckBox_Clicked);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.BackColor = System.Drawing.Color.GhostWhite;
            this.AddQuestionButton.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuestionButton.Image = global::TriviaClient.Properties.Resources.plus_math_35px;
            this.AddQuestionButton.Location = new System.Drawing.Point(193, 92);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(37, 37);
            this.AddQuestionButton.TabIndex = 5;
            this.MainToolTip.SetToolTip(this.AddQuestionButton, "Add question");
            this.AddQuestionButton.UseVisualStyleBackColor = false;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // Answer2TB
            // 
            this.Answer2TB.BackColor = System.Drawing.SystemColors.Menu;
            this.Answer2TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Answer2TB.Cue = "Answer";
            this.Answer2TB.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2TB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Answer2TB.Location = new System.Drawing.Point(287, 121);
            this.Answer2TB.Name = "Answer2TB";
            this.Answer2TB.Size = new System.Drawing.Size(123, 26);
            this.Answer2TB.TabIndex = 2;
            this.Answer2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Answer4TB
            // 
            this.Answer4TB.BackColor = System.Drawing.SystemColors.Menu;
            this.Answer4TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Answer4TB.Cue = "Answer";
            this.Answer4TB.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4TB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Answer4TB.Location = new System.Drawing.Point(12, 121);
            this.Answer4TB.Name = "Answer4TB";
            this.Answer4TB.Size = new System.Drawing.Size(123, 26);
            this.Answer4TB.TabIndex = 4;
            this.Answer4TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Answer3TB
            // 
            this.Answer3TB.BackColor = System.Drawing.SystemColors.Menu;
            this.Answer3TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Answer3TB.Cue = "Answer";
            this.Answer3TB.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3TB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Answer3TB.Location = new System.Drawing.Point(12, 73);
            this.Answer3TB.Name = "Answer3TB";
            this.Answer3TB.Size = new System.Drawing.Size(123, 26);
            this.Answer3TB.TabIndex = 3;
            this.Answer3TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Answer1TB
            // 
            this.Answer1TB.BackColor = System.Drawing.SystemColors.Menu;
            this.Answer1TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Answer1TB.Cue = "Answer";
            this.Answer1TB.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1TB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Answer1TB.Location = new System.Drawing.Point(287, 73);
            this.Answer1TB.Name = "Answer1TB";
            this.Answer1TB.Size = new System.Drawing.Size(123, 26);
            this.Answer1TB.TabIndex = 1;
            this.Answer1TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuestionTB
            // 
            this.QuestionTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.QuestionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionTB.Cue = "Question";
            this.QuestionTB.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.QuestionTB.Location = new System.Drawing.Point(12, 12);
            this.QuestionTB.Name = "QuestionTB";
            this.QuestionTB.Size = new System.Drawing.Size(398, 35);
            this.QuestionTB.TabIndex = 0;
            this.QuestionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddQuestion
            // 
            this.AcceptButton = this.AddQuestionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaClient.Properties.Resources.BrickWall;
            this.ClientSize = new System.Drawing.Size(422, 169);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.CB2);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.CB4);
            this.Controls.Add(this.CB3);
            this.Controls.Add(this.Answer2TB);
            this.Controls.Add(this.Answer4TB);
            this.Controls.Add(this.Answer3TB);
            this.Controls.Add(this.Answer1TB);
            this.Controls.Add(this.QuestionTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Trivia] Add Question";
            this.MainToolTip.SetToolTip(this, "Correct answer checker");
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.AddQuestion_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox QuestionTB;
        private CueTextBox Answer1TB;
        private CueTextBox Answer3TB;
        private CueTextBox Answer4TB;
        private CueTextBox Answer2TB;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.CheckBox CB4;
        private System.Windows.Forms.CheckBox CB1;
        private System.Windows.Forms.CheckBox CB2;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.ToolTip MainToolTip;
    }
}