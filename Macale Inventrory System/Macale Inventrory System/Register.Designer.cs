namespace Macale_Inventrory_System
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;
        private Panel registerPanel = null!;
        private Label titleLabel = null!;
        private Label subtitleLabel = null!;
        private Label fullNameLabel = null!;
        private Label usernameLabel = null!;
        private Label passwordLabel = null!;
        private Label confirmPasswordLabel = null!;
        private TextBox fullNameTextBox = null!;
        private TextBox usernameTextBox = null!;
        private TextBox passwordTextBox = null!;
        private TextBox confirmPasswordTextBox = null!;
        private Button registerButton = null!;
        private LinkLabel loginLinkLabel = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            registerPanel = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            fullNameLabel = new Label();
            usernameLabel = new Label();
            fullNameTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            confirmPasswordLabel = new Label();
            passwordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            registerButton = new Button();
            loginLinkLabel = new LinkLabel();
            registerPanel.SuspendLayout();
            SuspendLayout();
            registerPanel.BackColor = Color.FromArgb(151, 179, 213);
            registerPanel.BorderStyle = BorderStyle.FixedSingle;
            registerPanel.Controls.Add(titleLabel);
            registerPanel.Controls.Add(subtitleLabel);
            registerPanel.Controls.Add(fullNameLabel);
            registerPanel.Controls.Add(usernameLabel);
            registerPanel.Controls.Add(fullNameTextBox);
            registerPanel.Controls.Add(usernameTextBox);
            registerPanel.Controls.Add(passwordLabel);
            registerPanel.Controls.Add(confirmPasswordLabel);
            registerPanel.Controls.Add(passwordTextBox);
            registerPanel.Controls.Add(confirmPasswordTextBox);
            registerPanel.Controls.Add(registerButton);
            registerPanel.Controls.Add(loginLinkLabel);
            registerPanel.Location = new Point(90, 50);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(720, 425);
            registerPanel.TabIndex = 0;
            titleLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(12, 25, 115);
            titleLabel.Location = new Point(35, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(648, 38);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "INVENTORY MANAGEMENT SYSTEM";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.Black;
            subtitleLabel.Location = new Point(35, 56);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(648, 28);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Create your Account";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI", 13F);
            fullNameLabel.Location = new Point(56, 100);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(115, 30);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name:";
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 13F);
            usernameLabel.Location = new Point(377, 99);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(116, 30);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            fullNameTextBox.Font = new Font("Segoe UI", 11F);
            fullNameTextBox.Location = new Point(54, 133);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(266, 32);
            fullNameTextBox.TabIndex = 4;
            usernameTextBox.Font = new Font("Segoe UI", 11F);
            usernameTextBox.Location = new Point(374, 133);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(266, 32);
            usernameTextBox.TabIndex = 5;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 13F);
            passwordLabel.Location = new Point(56, 201);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(108, 30);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 13F);
            confirmPasswordLabel.Location = new Point(375, 201);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(198, 30);
            confirmPasswordLabel.TabIndex = 7;
            confirmPasswordLabel.Text = "Re-enter Password:";
            passwordTextBox.Font = new Font("Segoe UI", 11F);
            passwordTextBox.Location = new Point(54, 235);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(266, 32);
            passwordTextBox.TabIndex = 8;
            passwordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 11F);
            confirmPasswordTextBox.Location = new Point(374, 235);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(266, 32);
            confirmPasswordTextBox.TabIndex = 9;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            registerButton.BackColor = Color.FromArgb(24, 31, 126);
            registerButton.FlatAppearance.BorderColor = Color.White;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 13F);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(293, 298);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(108, 43);
            registerButton.TabIndex = 10;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            loginLinkLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            loginLinkLabel.LinkColor = Color.FromArgb(18, 45, 180);
            loginLinkLabel.Location = new Point(138, 362);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(420, 25);
            loginLinkLabel.TabIndex = 11;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Already have an account? Login here.";
            loginLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(900, 560);
            Controls.Add(registerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}