using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace AthletiQ
{
    public partial class UpdatePlayerForm : Form
    {
        public UpdatePlayerForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string jersey = txtJersey.Text;
            string newName = txtName.Text;
            string newTeam = txtTeam.Text;

            string connectionString = "server=localhost;database=athletiq;user=root;password=123456;";
            string query = "UPDATE Players SET Name = @Name, TeamName = @Team WHERE JerseyNumber = @Jersey";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", newName);
                cmd.Parameters.AddWithValue("@Team", newTeam);
                cmd.Parameters.AddWithValue("@Jersey", jersey);

                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected > 0 ? "Player updated!" : "No player found.");
            }
        }

        private void UpdatePlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
