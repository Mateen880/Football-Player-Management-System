namespace AthletiQ
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();

            // Create Labels
            Label lblTitle = new Label();
            lblTitle.Text = "Create Your Account";
            lblTitle.Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(50, 40);
            this.Controls.Add(lblTitle);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(50, 100);
            this.Controls.Add(lblUsername);

            TextBox txtUsername = new TextBox();
            txtUsername.Width = 280;
            txtUsername.Location = new System.Drawing.Point(50, 120);
            this.Controls.Add(txtUsername);

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(50, 150);
            this.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox();
            txtEmail.Width = 280;
            txtEmail.Location = new System.Drawing.Point(50, 170);
            this.Controls.Add(txtEmail);

            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(50, 200);
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Width = 280;
            txtPassword.Location = new System.Drawing.Point(50, 220);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            // Sign Up Button
            Button btnSignUp = new Button();
            btnSignUp.Text = "Sign Up";
            btnSignUp.BackColor = System.Drawing.Color.Green;
            btnSignUp.ForeColor = System.Drawing.Color.White;
            btnSignUp.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            btnSignUp.Location = new System.Drawing.Point(50, 270);
            btnSignUp.Width = 280;
            btnSignUp.Height = 40;
            btnSignUp.Click += (sender, e) => BtnSignUp_Click(sender, e, txtUsername.Text, txtEmail.Text, txtPassword.Text);
            this.Controls.Add(btnSignUp);

            // Already registered?
            Label lblAlreadyRegistered = new Label();
            lblAlreadyRegistered.Text = "Already have an account?";
            lblAlreadyRegistered.Font = new System.Drawing.Font("Arial", 10);
            lblAlreadyRegistered.AutoSize = true;
            lblAlreadyRegistered.Location = new System.Drawing.Point(100, 320);
            this.Controls.Add(lblAlreadyRegistered);

            // Login Button
            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.BackColor = System.Drawing.Color.Green;
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            btnLogin.Location = new System.Drawing.Point(50, 350);
            btnLogin.Width = 280;
            btnLogin.Height = 40;
            btnLogin.Click += BtnLogin_Click1;
            this.Controls.Add(btnLogin);

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
        }

        //private void BtnSignUp_Click(object sender, EventArgs e, string username, string email, string password)
        //{
        //    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        //    {
        //        MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void BtnLogin_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Redirecting to Login Page...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    LoginForm loginForm = new LoginForm();
        //    loginForm.Show();
        //    ((Form)sender).Hide();
        //}
    }
}
