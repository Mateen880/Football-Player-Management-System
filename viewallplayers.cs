using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AthletiQ
{
    public partial class ViewAllPlayersForm : Form
    {
        // Database connection string
        private string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";

        public ViewAllPlayersForm()
        {
            InitializeComponent();
        }

        private void BtnViewPlayers_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Name, Age, Position, JerseyNumber, InjuryStatus ,TeamName FROM Players";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvPlayers.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to retrieve players: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewAllPlayersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
