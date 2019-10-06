﻿using Controller.Service;
using Model;
using Model.Entity;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class UserForm : Form
    {
        private User user;
        private IMoodService _moodService;

        public UserForm(User user, IMoodService moodService)
        {
            this.user = user;
            _moodService = moodService;
            InitializeComponent();

            userInfoLabel.Text = "Hello " + user.Firstname + " " + user.Lastname;
        }

        private void startSessionButton_Click(object sender, System.EventArgs e)
        {
            SessionInfo sessionInfo = new SessionInfo
            {
                User = this.user,
                Subject = subjectTextBox.Text,
                Class = classTextBox.Text,
                Comments = commentsTextBox.Text,
                DateTime = dateTimePicker.Value
            };

            SessionForm sessionForm = new SessionForm(sessionInfo, _moodService);
            sessionForm.Show();
        }
    }
}
