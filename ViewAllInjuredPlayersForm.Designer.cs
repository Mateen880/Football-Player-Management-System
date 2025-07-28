namespace AthletiQ
{
    partial class ViewInjuredPlayersForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewInjured;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewInjured = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInjured).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInjured
            // 
            dataGridViewInjured.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInjured.Location = new Point(12, 12);
            dataGridViewInjured.Name = "dataGridViewInjured";
            dataGridViewInjured.RowHeadersWidth = 62;
            dataGridViewInjured.Size = new Size(560, 337);
            dataGridViewInjured.TabIndex = 0;
            dataGridViewInjured.CellContentClick += dataGridViewInjured_CellContentClick;
            // 
            // ViewInjuredPlayersForm
            // 
            ClientSize = new Size(584, 361);
            Controls.Add(dataGridViewInjured);
            Name = "ViewInjuredPlayersForm";
            Text = "View Injured Players";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInjured).EndInit();
            ResumeLayout(false);
        }
    }
}
