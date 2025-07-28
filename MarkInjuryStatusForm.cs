using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AthletiQ
{
    public partial class MarkInjuryStatusForm : Form
    {
        public MarkInjuryStatusForm()
        {
            InitializeComponent();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();
            if (string.IsNullOrEmpty(playerName)) return;

            string connStr = "server=localhost;database=athletiq;user=root;password=123456;";
            string query = "SELECT InjuryStatus FROM Players WHERE Name = @Name";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", playerName);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string currentStatus = result.ToString();
                    lblCurrentStatus.Text = $"Current Status: {currentStatus}";
                    btnToggleStatus.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Player not found.");
                }
            }
        }

        private void btnToggleStatus_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();
            string connStr = "server=localhost;database=athletiq;user=root;password=123456;";
            string queryGet = "SELECT InjuryStatus FROM Players WHERE Name = @Name";
            string queryUpdate = "UPDATE Players SET InjuryStatus = @Status WHERE Name = @Name";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmdGet = new MySqlCommand(queryGet, conn);
                cmdGet.Parameters.AddWithValue("@Name", playerName);
                string currentStatus = cmdGet.ExecuteScalar().ToString();

                string newStatus = currentStatus == "Fit" ? "Injured" : "Fit";
                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@Status", newStatus);
                cmdUpdate.Parameters.AddWithValue("@Name", playerName);
                cmdUpdate.ExecuteNonQuery();

                lblCurrentStatus.Text = $"Status updated to: {newStatus}";
            }
        }
    }
}
