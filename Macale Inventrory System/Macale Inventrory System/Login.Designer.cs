namespace Macale_Inventrory_System
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private Panel loginPanel = null!;
        private Label titleLabel = null!;
        private Label subtitleLabel = null!;
        private Label usernameLabel = null!;
        private Label passwordLabel = null!;
        private TextBox usernameTextBox = null!;
        private TextBox passwordTextBox = null!;
        private Button signInButton = null!;
        private LinkLabel registerLinkLabel = null!;

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
            loginPanel = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            signInButton = new Button();
            registerLinkLabel = new LinkLabel();
            loginPanel.SuspendLayout();
            SuspendLayout();
            loginPanel.BackColor = Color.White;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(titleLabel);
            loginPanel.Controls.Add(subtitleLabel);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(usernameTextBox);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(signInButton);
            loginPanel.Controls.Add(registerLinkLabel);
            loginPanel.Location = new Point(250, 55);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(400, 430);
            loginPanel.TabIndex = 0;
            titleLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(12, 25, 115);
            titleLabel.Location = new Point(38, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(322, 70);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "INVENTORY MANAGEMENT\nSYSTEM";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.Black;
            subtitleLabel.Location = new Point(38, 96);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(322, 28);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Sign In to your Account";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 13F);
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(68, 158);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(116, 30);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            usernameTextBox.Font = new Font("Segoe UI", 11F);
            usernameTextBox.Location = new Point(68, 188);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(264, 32);
            usernameTextBox.TabIndex = 3;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 13F);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(68, 230);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(108, 30);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            passwordTextBox.Font = new Font("Segoe UI", 11F);
            passwordTextBox.Location = new Point(68, 260);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(264, 32);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            signInButton.BackColor = Color.FromArgb(24, 31, 126);
            signInButton.FlatAppearance.BorderColor = Color.FromArgb(24, 31, 126);
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.Font = new Font("Segoe UI", 13F);
            signInButton.ForeColor = Color.White;
            signInButton.Location = new Point(140, 312);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(106, 43);
            signInButton.TabIndex = 6;
            signInButton.Text = "Sign In  ↪";
            signInButton.UseVisualStyleBackColor = false;
            registerLinkLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            registerLinkLabel.LinkColor = Color.FromArgb(18, 45, 180);
            registerLinkLabel.Location = new Point(38, 374);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(322, 25);
            registerLinkLabel.TabIndex = 7;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Don't have an account? Register here.";
            registerLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 250, 252);
            ClientSize = new Size(900, 560);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}