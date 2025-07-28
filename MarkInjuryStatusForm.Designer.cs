namespace AthletiQ
{
    partial class MarkInjuryStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtPlayerName;
        private Button btnCheckStatus;
        private Label lblCurrentStatus;
        private Button btnToggleStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtPlayerName = new TextBox();
            btnCheckStatus = new Button();
            lblCurrentStatus = new Label();
            btnToggleStatus = new Button();
            SuspendLayout();

            txtPlayerName.Location = new System.Drawing.Point(30, 30);
            txtPlayerName.Width = 200;

            btnCheckStatus.Text = "Check Status";
            btnCheckStatus.Location = new System.Drawing.Point(250, 28);
            btnCheckStatus.Click += btnCheckStatus_Click;

            lblCurrentStatus.Text = "Current Status:";
            lblCurrentStatus.Location = new System.Drawing.Point(30, 80);
            lblCurrentStatus.AutoSize = true;

            btnToggleStatus.Text = "Toggle Status";
            btnToggleStatus.Location = new System.Drawing.Point(30, 120);
            btnToggleStatus.Enabled = false;
            btnToggleStatus.Click += btnToggleStatus_Click;

            Controls.Add(txtPlayerName);
            Controls.Add(btnCheckStatus);
            Controls.Add(lblCurrentStatus);
            Controls.Add(btnToggleStatus);

            Text = "Mark Injury Status";
            ClientSize = new System.Drawing.Size(400, 200);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
