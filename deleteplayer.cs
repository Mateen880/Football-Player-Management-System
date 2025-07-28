using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AthletiQ
{
    public partial class RemovePlayerForm : Form
    {
        // MySQL connection string (update if your config changes)
        private string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";

        public RemovePlayerForm()
        {
            InitializeComponent();
            btnRemove.Click += BtnRemovePlayer_Click;
        }

        private void BtnRemovePlayer_Click(object sender, EventArgs e)
        {
            string input = txtPlayerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a player name or jersey number.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to remove this player?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query;
                    MySqlCommand cmd;

                    if (int.TryParse(input, out int jerseyNumber))
                    {
                        query = "DELETE FROM Players WHERE JerseyNumber = @jersey";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@jersey", jerseyNumber);
                    }
                    else
                    {
                        query = "DELETE FROM Players WHERE Name = @name";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", input);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Player removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPlayerName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No player found with that name or jersey number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}