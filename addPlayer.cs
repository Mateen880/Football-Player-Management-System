using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Include MySQL connector

namespace AthletiQ
{
    public partial class AddPlayerForm : Form
    {
        // MySQL Connection String - Replace with your actual credentials
        private string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";

        public AddPlayerForm()
        {
            InitializeComponent();
            btnAddPlayer.Click += BtnAddPlayer_Click; // Event handler for button click
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            // Get values from input fields
            string playerName = txtPlayerName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string position = txtPosition.Text.Trim();
            string jerseyText = txtJerseyNumber.Text.Trim();
            string injuryStatus = cmbInjuryStatus.SelectedItem?.ToString();
            string teamName = txtTeamName.Text.Trim();

            // Validation - Ensure all fields are filled
            if (string.IsNullOrWhiteSpace(playerName) || string.IsNullOrWhiteSpace(ageText) ||
                string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(jerseyText) ||
                string.IsNullOrWhiteSpace(injuryStatus) || string.IsNullOrWhiteSpace(teamName))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert numeric values
            if (!int.TryParse(ageText, out int age) || !int.TryParse(jerseyText, out int jerseyNumber))
            {
                MessageBox.Show("Age and Jersey Number must be valid numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert into database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Players (Name, Age, Position, TeamName, JerseyNumber, InjuryStatus) " +
                                   "VALUES (@name, @age, @position, @team, @jersey, @injury)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", playerName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@team", teamName);
                        cmd.Parameters.AddWithValue("@jersey", jerseyNumber);
                        cmd.Parameters.AddWithValue("@injury", injuryStatus);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Player added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Clear input fields after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to clear input fields
        private void ClearFields()
        {
            txtPlayerName.Clear();
            txtAge.Clear();
            txtPosition.Clear();
            txtJerseyNumber.Clear();
            txtTeamName.Clear();
            cmbInjuryStatus.SelectedIndex = -1;
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            // Optional: Actions on form load
        }
    }
}
