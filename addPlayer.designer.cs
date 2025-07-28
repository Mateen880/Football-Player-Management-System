namespace AthletiQ
{
    partial class AddPlayerForm
    {
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            txtPlayerName = new TextBox();
            label2 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtPosition = new TextBox();
            label6 = new Label();
            txtTeamName = new TextBox();
            label4 = new Label();
            txtJerseyNumber = new TextBox();
            label5 = new Label();
            cmbInjuryStatus = new ComboBox();
            btnAddPlayer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(457, 62);
            txtPlayerName.Margin = new Padding(4, 5, 4, 5);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(213, 31);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(457, 128);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(213, 31);
            txtAge.TabIndex = 3;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 4;
            label3.Text = "Position";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(457, 195);
            txtPosition.Margin = new Padding(4, 5, 4, 5);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(213, 31);
            txtPosition.TabIndex = 5;
            txtPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 267);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 6;
            label6.Text = "Team Name";
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(457, 262);
            txtTeamName.Margin = new Padding(4, 5, 4, 5);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(213, 31);
            txtTeamName.TabIndex = 7;
            txtTeamName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 334);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 8;
            label4.Text = "Jersey Number";
            // 
            // txtJerseyNumber
            // 
            txtJerseyNumber.Location = new Point(457, 329);
            txtJerseyNumber.Margin = new Padding(4, 5, 4, 5);
            txtJerseyNumber.Name = "txtJerseyNumber";
            txtJerseyNumber.Size = new Size(213, 31);
            txtJerseyNumber.TabIndex = 9;
            txtJerseyNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 401);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 10;
            label5.Text = "Injury Status";
            // 
            // cmbInjuryStatus
            // 
            cmbInjuryStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInjuryStatus.Items.AddRange(new object[] { "Fit", "Injured" });
            cmbInjuryStatus.Location = new Point(457, 396);
            cmbInjuryStatus.Margin = new Padding(4, 5, 4, 5);
            cmbInjuryStatus.Name = "cmbInjuryStatus";
            cmbInjuryStatus.Size = new Size(213, 33);
            cmbInjuryStatus.TabIndex = 11;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(457, 485);
            btnAddPlayer.Margin = new Padding(4, 5, 4, 5);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(143, 50);
            btnAddPlayer.TabIndex = 12;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 667);
            Controls.Add(label1);
            Controls.Add(txtPlayerName);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(txtPosition);
            Controls.Add(label6);
            Controls.Add(txtTeamName);
            Controls.Add(label4);
            Controls.Add(txtJerseyNumber);
            Controls.Add(label5);
            Controls.Add(cmbInjuryStatus);
            Controls.Add(btnAddPlayer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddPlayerForm";
            Text = "AthletiQ - Add Player";
            Load += AddPlayerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1, label2, label3, label4, label5, label6;
        private TextBox txtPlayerName, txtAge, txtPosition, txtTeamName, txtJerseyNumber;
        private ComboBox cmbInjuryStatus;
        private Button btnAddPlayer;
    }
}
