using System;
using System.Drawing;
using System.Windows.Forms;

namespace AthletiQ
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblSignUp;
        private Button btnSignUp;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblSignUp = new Label();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(90, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(395, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login to Your Account";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Arial", 10F);
            lblSubtitle.Location = new Point(90, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(309, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your credentials to continue.";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblUsername.Location = new Point(90, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(134, 29);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(90, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(90, 200);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(133, 29);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(90, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Arial", 10F);
            lblSignUp.Location = new Point(90, 330);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(194, 23);
            lblSignUp.TabIndex = 7;
            lblSignUp.Text = "New to the platform?";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Green;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(90, 360);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(353, 40);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(537, 496);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblSignUp);
            Controls.Add(btnSignUp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
