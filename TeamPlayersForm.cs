using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AthletiQ
{
    public partial class TeamPlayersForm : Form
    {
        private string teamName;

        public TeamPlayersForm(string team)
        {
            InitializeComponent();
            teamName = team;
            LoadPlayersByTeam();
        }

        private void LoadPlayersByTeam()
        {
            string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";
            string query = "SELECT * FROM Players WHERE TeamName = @Team";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Team", teamName);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewTeamPlayers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading players: " + ex.Message);
                }
            }
        }

        private void dataGridViewTeamPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
