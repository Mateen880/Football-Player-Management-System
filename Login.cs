using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // MySQL Library

namespace AthletiQ
{
    public partial class LoginForm : Form
    {
        private string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6 || password.Length > 12)
            {
                MessageBox.Show("Password must be between 6 and 12 characters.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Navigate to HomePage on successful login
                            HomePage homePage = new HomePage();
                            homePage.Show();
                            this.Hide(); // Hide LoginForm
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signupForm = new SignUpForm();
            signupForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: Actions on form load
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
