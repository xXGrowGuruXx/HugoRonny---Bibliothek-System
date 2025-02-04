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
    public partial class KundeStrafen : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        string _username = string.Empty;

        public KundeStrafen(string username)
        {
            InitializeComponent();
            _username = username;
        }
        private void KundeStrafen_Load(object sender, EventArgs e)
        {
            KundeStrafen_Seitenname.Font = überschrift;

            KundeStrafen_Bezahlen.Font = button;
            KundeStrafen_Zurück.Font = button;

            KundenÜbersicht kundenÜbersicht = new KundenÜbersicht(_username);
            kundenÜbersicht.ShowStrafen(KundeStrafen_Grid);
            kundenÜbersicht.LoadStrafen(KundeStrafen_Strafauswahl, KundeStrafen_Grid);
        }
        private void kundeStrafen(object sender, FormClosingEventArgs e)
        {
            KundeMain kundeMain = KundeMain.GetInstance();
            kundeMain.Show();
        }

        private void KundeStrafen_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KundeStrafen_MouseEnter(object sender, EventArgs e)
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
                KundeStrafen_Strafauswahl.ForeColor = Color.Black;
                KundeStrafen_Strafauswahl.BackColor = Color.FromArgb(128, Color.White);
            }
        }

        private void KundeStrafen_MouseLeave(object sender, EventArgs e)
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
                KundeStrafen_Strafauswahl.ForeColor = Color.White;
                KundeStrafen_Strafauswahl.BackColor = Color.FromArgb(0);
            }
        }
        private void KundeStrafen_Buttons_Click(object sender, EventArgs e)
        {
            KundenÜbersicht kundenÜbersicht = new KundenÜbersicht(_username);
            kundenÜbersicht.StrafeZahlen(KundeStrafen_Strafauswahl, KundeStrafen_Grid);
        }

        private void KundeStrafen_Strafauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KundeStrafen_Strafauswahl.Text))
            {
                KundeStrafen_Bezahlen.Visible = true;
            }
            else
            {
                KundeStrafen_Bezahlen.Visible = false;
            }
        }
    }
}
