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

namespace Bibliothek.Mitarbeiter
{
    public partial class Mitarbeiter_Kunden : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public Mitarbeiter_Kunden()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(800,600);
        }

        private void Mitarbeiter_Kunden_Load(object sender, EventArgs e)
        {
            kunden_Seitenname.Font = überschrift;
            kunden_Label_Name.Font = label;
            kunden_Label_Username.Font = label;
            kunden_Label_Vorname.Font = label;
            kunden_Label_Strasse.Font = label;
            kunden_Label_Ort.Font = label;
            kunden_Label_PLZ.Font = label;
            kunden_Username.Font = label;
            kunden_Name.Font = label;
            kunden_Vorname.Font = label;
            kunden_Strasse.Font = label;
            kunden_Ort.Font = label;
            kunden_PLZ.Font = label;
            kunden_Speichern.Font = button;
            kunden_deaktivieren.Font = button;
            kunden_Ausgeliehen.Font = button;
            kunden_Reservierungen.Font = button;
            kunden_Zurueck.Font = button;
        }

        private void mitarbeiter_Kunden(object sender, FormClosingEventArgs e)
        {
            MitarbeiterMain mitarbeiterMain = MitarbeiterMain.GetInstance();
            mitarbeiterMain.Show();
        }

        private void mitarbeiter_Kunden_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_Kunden_MouseEnter(object sender, EventArgs e)
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
                kunden_Auswahl_neu.ForeColor = Color.Black;
                kunden_Auswahl_neu.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == kunden_Name)
                {
                    kunden_Name.ForeColor = Color.Black;
                    kunden_Name.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == kunden_Username)
                {
                    kunden_Username.ForeColor = Color.Black;
                    kunden_Username.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == kunden_Vorname)
                {
                    kunden_Vorname.ForeColor = Color.Black;
                    kunden_Vorname.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == kunden_Strasse)
                {
                    kunden_Strasse.ForeColor = Color.Black;
                    kunden_Strasse.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == kunden_Ort)
                {
                    kunden_Ort.ForeColor = Color.Black;
                    kunden_Ort.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == kunden_PLZ)
                {
                    kunden_PLZ.ForeColor = Color.Black;
                    kunden_PLZ.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }

        private void mitarbeiter_Kunden_MouseLeave(object sender, EventArgs e)
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
                kunden_Auswahl_neu.ForeColor = Color.White;
                kunden_Auswahl_neu.BackColor = Color.FromArgb(0);
            }
            else if (textBox != null)
            {
                if (textBox == kunden_Name)
                {
                    kunden_Name.ForeColor = Color.White;
                    kunden_Name.BackColor = Color.FromArgb(0);
                }
                else if (textBox == kunden_Username)
                {
                    kunden_Username.ForeColor = Color.White;
                    kunden_Username.BackColor = Color.FromArgb(0);
                }
                else if (textBox == kunden_Vorname)
                {
                    kunden_Vorname.ForeColor = Color.White;
                    kunden_Vorname.BackColor = Color.FromArgb(0);
                }
                else if (textBox == kunden_Strasse)
                {
                    kunden_Strasse.ForeColor = Color.White;
                    kunden_Strasse.BackColor = Color.FromArgb(0);
                }
                else if (textBox == kunden_Ort)
                {
                    kunden_Ort.ForeColor = Color.White;
                    kunden_Ort.BackColor = Color.FromArgb(0);
                }
                else if (textBox == kunden_PLZ)
                {
                    kunden_PLZ.ForeColor = Color.White;
                    kunden_PLZ.BackColor = Color.FromArgb(0);
                }
            }
        }

        private void kunden_Reservierungen_Click(object sender, EventArgs e)
        {

        }
    }
}
