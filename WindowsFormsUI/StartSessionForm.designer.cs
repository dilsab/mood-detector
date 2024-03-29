﻿namespace WindowsFormsUI
{
    partial class StartSessionForm
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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.newsessionGroupBox = new System.Windows.Forms.GroupBox();
            this.startSessionButton = new System.Windows.Forms.Button();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newsessionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(148, 18);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(55, 17);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Subject";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(211, 15);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 22);
            this.subjectTextBox.TabIndex = 1;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(163, 46);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(42, 17);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(211, 43);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 22);
            this.classTextBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(181, 217);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(132, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start new session";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(11, 78);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(74, 17);
            this.commentsLabel.TabIndex = 5;
            this.commentsLabel.Text = "Comments";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(13, 97);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(464, 115);
            this.commentsTextBox.TabIndex = 6;
            // 
            // newsessionGroupBox
            // 
            this.newsessionGroupBox.Controls.Add(this.dateTimePicker);
            this.newsessionGroupBox.Controls.Add(this.startSessionButton);
            this.newsessionGroupBox.Controls.Add(this.dateAndTimeLabel);
            this.newsessionGroupBox.Controls.Add(this.subjectLabel);
            this.newsessionGroupBox.Controls.Add(this.commentsTextBox);
            this.newsessionGroupBox.Controls.Add(this.subjectTextBox);
            this.newsessionGroupBox.Controls.Add(this.commentsLabel);
            this.newsessionGroupBox.Controls.Add(this.classLabel);
            this.newsessionGroupBox.Controls.Add(this.startButton);
            this.newsessionGroupBox.Controls.Add(this.classTextBox);
            this.newsessionGroupBox.Location = new System.Drawing.Point(12, 50);
            this.newsessionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newsessionGroupBox.Name = "newsessionGroupBox";
            this.newsessionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newsessionGroupBox.Size = new System.Drawing.Size(599, 218);
            this.newsessionGroupBox.TabIndex = 7;
            this.newsessionGroupBox.TabStop = false;
            this.newsessionGroupBox.Text = "New Session";
            // 
            // startSessionButton
            // 
            this.startSessionButton.Location = new System.Drawing.Point(485, 183);
            this.startSessionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startSessionButton.Name = "startSessionButton";
            this.startSessionButton.Size = new System.Drawing.Size(107, 28);
            this.startSessionButton.TabIndex = 8;
            this.startSessionButton.Text = "Start Session";
            this.startSessionButton.UseVisualStyleBackColor = true;
            this.startSessionButton.Click += new System.EventHandler(this.startSessionButton_Click);
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.AutoSize = true;
            this.dateAndTimeLabel.Location = new System.Drawing.Point(327, 18);
            this.dateAndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(101, 17);
            this.dateAndTimeLabel.TabIndex = 7;
            this.dateAndTimeLabel.Text = "Date and Time";
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Location = new System.Drawing.Point(16, 11);
            this.userInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(65, 17);
            this.userInfoLabel.TabIndex = 9;
            this.userInfoLabel.Text = "User info";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(328, 41);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // StartSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 279);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.newsessionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Session";
            this.newsessionGroupBox.ResumeLayout(false);
            this.newsessionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.GroupBox newsessionGroupBox;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label dateAndTimeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button startSessionButton;
    }
}