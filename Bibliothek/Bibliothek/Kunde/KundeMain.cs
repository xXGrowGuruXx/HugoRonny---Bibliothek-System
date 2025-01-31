using Bibliothek.Mitarbeiter;
using Bibliothek.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothek.Kunde
{
    public partial class KundeMain : Form
    {
        private static KundeMain instance;

        public static KundeMain GetInstance()
        {
            return instance;
        }

        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);
        public KundeMain()
        {
            instance = this;
            InitializeComponent();
        }

        private void KundeMain_Load(object sender, EventArgs e)
        {
            KundenHUB.Font = überschrift;

            Kunde_Suche.Font = button;
            Kunde_Rueckgabe.Font = button;
            Kunde_Reservierungen.Font = button;
            Kunde_Strafen.Font = button;
            Kunde_Abmelden.Font = button;


        }

        private void KundenMain(object sender, FormClosingEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
        }

        private void kundeMain_Abmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KundeMain_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kundeMain_Buttons_MouseEnter(object sender, EventArgs e)
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

        private void kundeMain_Buttons_MouseLeave(object sender, EventArgs e)
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

        private void kundeMain_Buttons_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (button == Kunde_Suche)
                {
                    KundeSuche kunde_suche = new KundeSuche();
                    kunde_suche.Show();
                    this.Hide();
                }
                if (button == Kunde_Rueckgabe)
                {
                    KundeRückgabe kunde_Rückgabe = new KundeRückgabe();
                    kunde_Rückgabe.Show();
                    this.Hide();
                }
                if (button == Kunde_Reservierungen)
                {
                    KundeReservierungen kunde_Reservierungen = new KundeReservierungen();
                    kunde_Reservierungen.Show();
                    this.Hide();
                }
                if (button == Kunde_Strafen)
                {
                    KundeStrafen kunde_Strafen = new KundeStrafen();
                    kunde_Strafen.Show();
                    this.Hide();
                }
                
            }
        }
    }
}
