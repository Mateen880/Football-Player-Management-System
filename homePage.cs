using System;
using System.Windows.Forms;

namespace AthletiQ
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:\\Users\\HP\\Downloads\\homepage.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.Show();
            this.Hide();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            RemovePlayerForm removePlayerForm = new RemovePlayerForm();
            removePlayerForm.Show();
            this.Hide();
        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            ViewAllPlayersForm viewAllPlayersForm = new ViewAllPlayersForm();
            viewAllPlayersForm.Show();
            this.Hide();
        }

        private void btnBarcelona_Click(object sender, EventArgs e)
        {
            TeamPlayersForm form = new TeamPlayersForm("Barcelona");
            form.Show();
            this.Hide();
        }

        private void btnRealMadrid_Click(object sender, EventArgs e)
        {
            TeamPlayersForm form = new TeamPlayersForm("Real Madrid");
            form.Show();
            this.Hide();
        }

        private void btnBayern_Click(object sender, EventArgs e)
        {
            TeamPlayersForm form = new TeamPlayersForm("Bayern Munich");
            form.Show();
            this.Hide();
        }

        private void btnLiverpool_Click(object sender, EventArgs e)
        {
            TeamPlayersForm form = new TeamPlayersForm("Liverpool");
            form.Show();
            this.Hide();
        }

        private void btnMarkInjury_Click(object sender, EventArgs e)
        {
            MarkInjuryStatusForm form = new MarkInjuryStatusForm();
            form.Show();
            this.Hide();
        }

        private void btnViewInjured_Click(object sender, EventArgs e)
        {
            ViewInjuredPlayersForm form = new ViewInjuredPlayersForm();
            form.Show();
            this.Hide();
        }

        private void btnSearchSpecific_Click(object sender, EventArgs e)
        {
            SearchPlayerForm form = new SearchPlayerForm();
            form.Show();
            this.Hide();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayerForm form = new UpdatePlayerForm();
            form.Show();
            this.Hide();
        }
    }
}
