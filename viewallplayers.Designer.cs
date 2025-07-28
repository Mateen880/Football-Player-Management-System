namespace AthletiQ
{
    partial class ViewAllPlayersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnViewPlayers;
        private System.Windows.Forms.DataGridView dgvPlayers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnViewPlayers = new Button();
            dgvPlayers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            SuspendLayout();
            // 
            // btnViewPlayers
            // 
            btnViewPlayers.Location = new Point(30, 30);
            btnViewPlayers.Name = "btnViewPlayers";
            btnViewPlayers.Size = new Size(180, 40);
            btnViewPlayers.TabIndex = 0;
            btnViewPlayers.Text = "View All Players";
            btnViewPlayers.UseVisualStyleBackColor = true;
            btnViewPlayers.Click += BtnViewPlayers_Click;
            // 
            // dgvPlayers
            // 
            dgvPlayers.AllowUserToAddRows = false;
            dgvPlayers.AllowUserToDeleteRows = false;
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayers.Location = new Point(30, 90);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.ReadOnly = true;
            dgvPlayers.RowHeadersWidth = 51;
            dgvPlayers.RowTemplate.Height = 29;
            dgvPlayers.Size = new Size(700, 300);
            dgvPlayers.TabIndex = 1;
            // 
            // ViewAllPlayersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(dgvPlayers);
            Controls.Add(btnViewPlayers);
            Name = "ViewAllPlayersForm";
            Text = "View All Players - AthletiQ";
            Load += ViewAllPlayersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
