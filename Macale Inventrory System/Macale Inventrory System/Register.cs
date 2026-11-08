using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macale_Inventrory_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            registerButton.Click += RegisterButton_Click;
            loginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("The passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Database.RegisterUser(fullNameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, out string message))
                {
                    MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }

                MessageBox.Show(message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginLinkLabel_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
