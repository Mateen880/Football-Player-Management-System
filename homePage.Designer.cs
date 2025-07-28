using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AthletiQ
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Button btnBarcelona, btnRealMadrid, btnBayern, btnLiverpool;
        private Button btnAddPlayer, btnRemovePlayer, btnSearchPlayer;
        private Button btnMarkInjury, btnViewInjured, btnSearchSpecific;
        private Button btnUpdatePlayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new Label();
            this.btnBarcelona = new Button();
            this.btnRealMadrid = new Button();
            this.btnBayern = new Button();
            this.btnLiverpool = new Button();
            this.btnAddPlayer = new Button();
            this.btnRemovePlayer = new Button();
            this.btnSearchPlayer = new Button();
            this.btnMarkInjury = new Button();
            this.btnViewInjured = new Button();
            this.btnSearchSpecific = new Button();
            this.btnUpdatePlayer = new Button();

            //
            // HomePage
            //
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 750);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "AthletiQ";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            //
            // labelTitle
            //
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Text = "AthletiQ";
            this.labelTitle.Location = new System.Drawing.Point(430, 20);

            // === Team Buttons ===
            ConfigureButton(btnBarcelona, "Barcelona", 100, 120, System.Drawing.Color.DarkGreen);
            ConfigureButton(btnRealMadrid, "Real Madrid", 340, 120, System.Drawing.Color.DarkGreen);
            ConfigureButton(btnBayern, "Bayern Munich", 580, 120, System.Drawing.Color.DarkGreen);
            ConfigureButton(btnLiverpool, "Liverpool", 820, 120, System.Drawing.Color.DarkGreen);

            // === Second Row (Functionality Row 1) ===
            ConfigureButton(btnAddPlayer, "Add Player", 230, 220, System.Drawing.Color.FromArgb(15, 23, 42));
            ConfigureButton(btnRemovePlayer, "Remove Player", 480, 220, System.Drawing.Color.FromArgb(15, 23, 42));
            ConfigureButton(btnSearchPlayer, "View All Players", 720, 220, System.Drawing.Color.FromArgb(15, 23, 42));

            // === Third Row (Functionality Row 2) ===
            ConfigureButton(btnMarkInjury, "Mark Injury Status", 230, 290, System.Drawing.Color.FromArgb(15, 23, 42));
            ConfigureButton(btnViewInjured, "View Injured Players", 480, 290, System.Drawing.Color.FromArgb(15, 23, 42));
            ConfigureButton(btnSearchSpecific, "Search Player", 720, 290, System.Drawing.Color.FromArgb(15, 23, 42));

            // === Fourth Row (Functionality Row 3 - centered) ===
            ConfigureButton(btnUpdatePlayer, "Update Player Info", 480, 360, System.Drawing.Color.FromArgb(15, 23, 42));

            // === Event Handlers ===
            btnBarcelona.Click += new EventHandler(this.btnBarcelona_Click);
            btnRealMadrid.Click += new EventHandler(this.btnRealMadrid_Click);
            btnBayern.Click += new EventHandler(this.btnBayern_Click);
            btnLiverpool.Click += new EventHandler(this.btnLiverpool_Click);
            btnAddPlayer.Click += new EventHandler(this.btnAddPlayer_Click);
            btnRemovePlayer.Click += new EventHandler(this.btnRemovePlayer_Click);
            btnSearchPlayer.Click += new EventHandler(this.btnSearchPlayer_Click);
            btnMarkInjury.Click += new EventHandler(this.btnMarkInjury_Click);
            btnViewInjured.Click += new EventHandler(this.btnViewInjured_Click);
            btnSearchSpecific.Click += new EventHandler(this.btnSearchSpecific_Click);
            btnUpdatePlayer.Click += new EventHandler(this.btnUpdatePlayer_Click);

            // === Controls ===
            this.Controls.Add(labelTitle);
            this.Controls.Add(btnBarcelona);
            this.Controls.Add(btnRealMadrid);
            this.Controls.Add(btnBayern);
            this.Controls.Add(btnLiverpool);
            this.Controls.Add(btnAddPlayer);
            this.Controls.Add(btnRemovePlayer);
            this.Controls.Add(btnSearchPlayer);
            this.Controls.Add(btnMarkInjury);
            this.Controls.Add(btnViewInjured);
            this.Controls.Add(btnSearchSpecific);
            this.Controls.Add(btnUpdatePlayer);
        }

        private void ConfigureButton(Button btn, string text, int x, int y, System.Drawing.Color backColor)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.Size = new System.Drawing.Size(160, 45);
            btn.Location = new System.Drawing.Point(x, y);
            btn.BackColor = backColor;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 30, 30));
        }
    }
}
