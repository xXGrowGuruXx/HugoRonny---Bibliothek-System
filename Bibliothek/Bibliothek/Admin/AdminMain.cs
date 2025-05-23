﻿using Bibliothek.utils;
using Bibliothek.Admin;

namespace Bibliothek.Admin
{
    public partial class AdminMain : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        private static AdminMain instance;

        public static AdminMain GetInstance()
        {
            return instance;
        }

        public AdminMain()
        {
            instance = this;
            InitializeComponent();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
        }

        private void adminMain_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            adminMain_Name.Font = überschrift;
            adminMain_Mitarbeiter.Font = button;
            adminMain_Statistik.Font = button;
            adminMain_Logout.Font = button;
        }

        private void adminMain_Buttons_MouseEnter(object sender, EventArgs e)
        {
            // Casten des Senders zu einem Button
            Button? button = sender as Button;
            if (button != null)
            {
                // Ändere die Hintergrundfarbe des Buttons auf halbtransparent
                button.BackColor = Color.FromArgb(128, Color.White);
                button.ForeColor = Color.Black;
            }
        }

        private void adminMain_Buttons_MouseLeave(object sender, EventArgs e)
        {
            // Casten des Senders zu einem Button
            Button? button = sender as Button;
            if (button != null)
            {
                // Ändere die Hintergrundfarbe des Buttons auf halbtransparent
                button.BackColor = Color.FromArgb(0);
                button.ForeColor = Color.White;
            }
        }

        private void adminMain_Mitarbeiter_Click(object sender, EventArgs e)
        {
            MitarbeiterHandling mitarbeiterHandling = new MitarbeiterHandling();
            mitarbeiterHandling.Show();
            this.Hide();
        }

        private void adminMain_Statistik_Click(object sender, EventArgs e)
        {
            Statistik statistik = new Statistik();
            statistik.Show();
            this.Hide();
        }
    }
}
