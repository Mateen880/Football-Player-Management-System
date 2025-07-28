namespace AthletiQ
{
    partial class UpdatePlayerForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtJersey;
        private TextBox txtName;
        private TextBox txtTeam;
        private Button btnUpdate;
        private Label lblJersey;
        private Label lblName;
        private Label lblTeam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtJersey = new TextBox();
            txtName = new TextBox();
            txtTeam = new TextBox();
            btnUpdate = new Button();
            lblJersey = new Label();
            lblName = new Label();
            lblTeam = new Label();
            SuspendLayout();
            // 
            // txtJersey
            // 
            txtJersey.Location = new Point(150, 20);
            txtJersey.Name = "txtJersey";
            txtJersey.Size = new Size(100, 31);
            txtJersey.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 31);
            txtName.TabIndex = 3;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(150, 100);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(100, 31);
            txtTeam.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblJersey
            // 
            lblJersey.Location = new Point(20, 20);
            lblJersey.Name = "lblJersey";
            lblJersey.Size = new Size(100, 23);
            lblJersey.TabIndex = 0;
            lblJersey.Text = "Jersey Number:";
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 2;
            lblName.Text = "New Name:";
            // 
            // lblTeam
            // 
            lblTeam.Location = new Point(20, 100);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(100, 23);
            lblTeam.TabIndex = 4;
            lblTeam.Text = "New Team:";
            // 
            // UpdatePlayerForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(lblJersey);
            Controls.Add(txtJersey);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblTeam);
            Controls.Add(txtTeam);
            Controls.Add(btnUpdate);
            Name = "UpdatePlayerForm";
            Text = "Update Player";
            Load += UpdatePlayerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
