﻿using Bibliothek.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothek.Mitarbeiter
{
    public partial class MitarbeiterMain : Form
    {
        private static MitarbeiterMain instance;

        public static MitarbeiterMain GetInstance()
        { 
            return instance; 
        }

        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        public MitarbeiterMain()
        {
            instance = this;
            InitializeComponent();
        }

        private void MitarbeiterMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
        }

        private void mitarbeiter_Abmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mitarbeiter_Load(object sender, EventArgs e)
        {
            mitarbeiter_Name.Font = überschrift;
            mitarbeiter_Kunden.Font = button;
            mitarbeiter_Bücher.Font = button;
            mitarbeiter_Autoren.Font = button;
            mitarbeiter_Genres.Font = button;
            mitarbeiter_Abmelden.Font = button;
        }

        private void mitarbeiter_Buttons_MouseEnter(object sender, EventArgs e)
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

        private void mitarbeiter_Buttons_MouseLeave(object sender, EventArgs e)
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

        private void mitarbeiter_Buttons_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (button == mitarbeiter_Kunden)
                {
                    Mitarbeiter_Kunden mitarbeiter_Kunden = new Mitarbeiter_Kunden();
                    mitarbeiter_Kunden.Show();
                    this.Hide();
                }
                if (button == mitarbeiter_Autoren)
                {
                    Mitarbeiter_Autoren mitarbeiter_Autoren = new Mitarbeiter_Autoren();
                    mitarbeiter_Autoren.Show();
                    this.Hide();
                }
                if (button == mitarbeiter_Bücher)
                {
                    Mitarbeiter_Buecher mitarbeiter_Buecher = new Mitarbeiter_Buecher();
                    mitarbeiter_Buecher.Show();
                    this.Hide();
                }
                if (button == mitarbeiter_Genres)
                {
                    Mitarbeiter_Genre mitarbeiter_Genre = new Mitarbeiter_Genre();
                    mitarbeiter_Genre.Show();
                    this.Hide();
                }
            }
        }
    }
}
