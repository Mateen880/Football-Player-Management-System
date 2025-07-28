using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AthletiQ
{
    public partial class ViewInjuredPlayersForm : Form
    {
        public ViewInjuredPlayersForm()
        {
            InitializeComponent();
            LoadInjuredPlayers();
        }

        private void LoadInjuredPlayers()
        {
            string connStr = "server=localhost;database=athletiq;user=root;password=123456;";
            string query = "SELECT * FROM Players WHERE InjuryStatus = 'Injured'";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewInjured.DataSource = dt;
            }
        }

        private void dataGridViewInjured_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
