using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macale_Inventrory_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            signInButton.Click += SignInButton_Click;
            registerLinkLabel.LinkClicked += RegisterLinkLabel_LinkClicked;
        }

        private void SignInButton_Click(object? sender, EventArgs e)
        {
            try
            {
                if (Database.ValidateUser(usernameTextBox.Text, passwordTextBox.Text, out string message))
                {
                    Hide();
                    Dashboard dashboard = new();
                    dashboard.FormClosed += (_, _) => Close();
                    dashboard.Show();
                    return;
                }

                MessageBox.Show(message, "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterLinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using Register registerForm = new();
            Hide();
            registerForm.ShowDialog(this);
            Show();
        }
    }
}
