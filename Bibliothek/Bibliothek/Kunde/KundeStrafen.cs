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
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public KundeStrafen()
        {
            InitializeComponent();
        }
        private void KundeStrafen_Load(object sender, EventArgs e)
        {
            KundeStrafen_Seitenname.Font = überschrift;

            KundeStrafen_Abgeben.Font = button;
            KundeStrafen_Zurück.Font = button;
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
                KundeStrafen_Buchauswahl.ForeColor = Color.Black;
                KundeStrafen_Buchauswahl.BackColor = Color.FromArgb(128, Color.White);
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
                KundeStrafen_Buchauswahl.ForeColor = Color.White;
                KundeStrafen_Buchauswahl.BackColor = Color.FromArgb(0);
            }
        }
        private void KundeStrafen_Buttons_Click(object sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (button == KundeStrafen_Abgeben)
                {
                    
                }
              

            }
        }
    }
}
