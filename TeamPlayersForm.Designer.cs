namespace AthletiQ
{
    partial class TeamPlayersForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTeamPlayers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewTeamPlayers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeamPlayers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTeamPlayers
            // 
            dataGridViewTeamPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeamPlayers.Location = new Point(12, 12);
            dataGridViewTeamPlayers.Name = "dataGridViewTeamPlayers";
            dataGridViewTeamPlayers.RowHeadersWidth = 62;
            dataGridViewTeamPlayers.Size = new Size(560, 337);
            dataGridViewTeamPlayers.TabIndex = 0;
            dataGridViewTeamPlayers.CellContentClick += dataGridViewTeamPlayers_CellContentClick;
            // 
            // TeamPlayersForm
            // 
            ClientSize = new Size(584, 361);
            Controls.Add(dataGridViewTeamPlayers);
            Name = "TeamPlayersForm";
            Text = "Team Players";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeamPlayers).EndInit();
            ResumeLayout(false);
        }
    }
}
