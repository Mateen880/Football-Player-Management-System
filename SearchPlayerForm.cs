using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace AthletiQ
{
    public partial class SearchPlayerForm : Form
    {
        public SearchPlayerForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string jersey = txtJersey.Text.Trim();

            string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";
            string query = "SELECT * FROM Players WHERE Name LIKE @Name AND JerseyNumber LIKE @Jersey";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" + name + "%");
                adapter.SelectCommand.Parameters.AddWithValue("@Jersey", "%" + jersey + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewResults.DataSource = dt;
            }
        }
    }
}
