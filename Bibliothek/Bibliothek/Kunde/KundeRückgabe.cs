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
    public partial class KundeRückgabe : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        string _username = string.Empty;

        public KundeRückgabe(string username)
        {
            _username = username;
            InitializeComponent();
        }
        private void KundeRückgabe_Load(object sender, EventArgs e)
        {
            kundeRückgabe_Seitenname.Font = überschrift;

            kundeRückgabe_Abgeben.Font = button;
            kundeRückgabe_Zurück.Font = button;

            KundenÜbersicht kundenÜbersicht = new KundenÜbersicht(_username);
            kundenÜbersicht.ShowBücher(kundeRückgabe_Grid);
            kundenÜbersicht.LoadBücher(kundeRückgabe_Buchauswahl, kundeRückgabe_Grid);
        }
        private void kundeRückgabe(object sender, FormClosingEventArgs e)
        {
            KundeMain kundeMain = KundeMain.GetInstance();
            kundeMain.Show();
        }

        private void kundeRückgabe_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void kundeRückgabe_MouseEnter(object sender, EventArgs e)
        {
            ComboBox? comboBox = sender as ComboBox;
            TextBox? textBox = sender as TextBox;
            Button? button = sender as Button;

            if (button != null)
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (comboBox != null)
            {
                kundeRückgabe_Buchauswahl.ForeColor = Color.Black;
                kundeRückgabe_Buchauswahl.BackColor = Color.FromArgb(128, Color.White);
            }
        }

        private void kundeRückgabe_MouseLeave(object sender, EventArgs e)
        {
            ComboBox? comboBox = sender as ComboBox;
            TextBox? textBox = sender as TextBox;
            Button? button = sender as Button;

            if (button != null)
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(0);
            }
            else if (comboBox != null)
            {
                kundeRückgabe_Buchauswahl.ForeColor = Color.White;
                kundeRückgabe_Buchauswahl.BackColor = Color.FromArgb(0);
            }
        }
        private void kundeRückgabe_Buttons_Click(object sender, EventArgs e)
        {
            KundenÜbersicht kundenÜbersicht = new KundenÜbersicht(_username);
            kundenÜbersicht.BuchAbgeben(kundeRückgabe_Buchauswahl, kundeRückgabe_Grid);
        }

        private void kundeRückgabe_Buchauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kundeRückgabe_Buchauswahl.Text))
            {
                kundeRückgabe_Abgeben.Visible = true;
            }
            else
            {
                kundeRückgabe_Abgeben.Visible = false;
            }
        }
    }
}
