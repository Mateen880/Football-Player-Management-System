namespace AthletiQ
{
    partial class SearchPlayerForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtJersey;
        private Button btnSearch;
        private DataGridView dataGridViewResults;
        private Label lblName;
        private Label lblJersey;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtJersey = new TextBox();
            this.btnSearch = new Button();
            this.dataGridViewResults = new DataGridView();
            this.lblName = new Label();
            this.lblJersey = new Label();

            // 
            // Labels
            //
            lblName.Text = "Name:";
            lblName.Location = new System.Drawing.Point(20, 20);
            lblJersey.Text = "Jersey Number:";
            lblJersey.Location = new System.Drawing.Point(20, 60);

            // 
            // TextBoxes
            //
            txtName.Location = new System.Drawing.Point(150, 20);
            txtJersey.Location = new System.Drawing.Point(150, 60);

            // 
            // Button
            //
            btnSearch.Text = "Search";
            btnSearch.Location = new System.Drawing.Point(150, 100);
            btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // 
            // DataGridView
            //
            dataGridViewResults.Location = new System.Drawing.Point(20, 150);
            dataGridViewResults.Size = new System.Drawing.Size(500, 200);

            // 
            // SearchPlayerForm
            //
            this.ClientSize = new System.Drawing.Size(550, 370);
            this.Controls.Add(txtName);
            this.Controls.Add(txtJersey);
            this.Controls.Add(btnSearch);
            this.Controls.Add(lblName);
            this.Controls.Add(lblJersey);
            this.Controls.Add(dataGridViewResults);
            this.Text = "Search Player";
        }
    }
}
