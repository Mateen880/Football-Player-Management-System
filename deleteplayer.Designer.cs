namespace AthletiQ
{
    partial class RemovePlayerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblPlayerName;
        private TextBox txtPlayerName;
        private Button btnRemove;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblPlayerName = new Label();
            this.txtPlayerName = new TextBox();
            this.btnRemove = new Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 35);
            this.lblTitle.Text = "Remove a Player";

            // lblPlayerName
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.Location = new System.Drawing.Point(80, 100);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(130, 24);
            this.lblPlayerName.Text = "Player Name:";

            // txtPlayerName
            this.txtPlayerName.Location = new System.Drawing.Point(80, 130);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(300, 30);

            // btnRemove
            this.btnRemove.BackColor = System.Drawing.Color.Green;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(80, 180);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(300, 40);
            this.btnRemove.Text = "Remove Player";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemovePlayer_Click);

            // RemovePlayerForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnRemove);
            this.Name = "RemovePlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Player";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}