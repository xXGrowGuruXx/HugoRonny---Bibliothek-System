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
    public partial class Mitarbeiter_Autoren : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public Mitarbeiter_Autoren()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Autoren_Load(object sender, EventArgs e)
        {
            Autoren_Seitenname.Font = überschrift;
            Autoren_Label_Name.Font = label;
            Autoren_Name.Font = label;
            Autoren_Speichern.Font = button;
            Autoren_Zurueck.Font = button;
        }
        private void mitarbeiter_Autoren(object sender, FormClosingEventArgs e)
        {
            MitarbeiterMain mitarbeiterMain = MitarbeiterMain.GetInstance();
            mitarbeiterMain.Show();
        }

        private void mitarbeiter_Autoren_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_Autoren_MouseEnter(object sender, EventArgs e)
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
                Autoren_Auswahl_neu.ForeColor = Color.Black;
                Autoren_Auswahl_neu.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == Autoren_Name)
                {
                    Autoren_Name.ForeColor = Color.Black;
                    Autoren_Name.BackColor = Color.FromArgb(128, Color.White);
                }
                
            }
        }

        private void mitarbeiter_Autoren_MouseLeave(object sender, EventArgs e)
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
                Autoren_Auswahl_neu.ForeColor = Color.White;
                Autoren_Auswahl_neu.BackColor = Color.FromArgb(0);
            }
            else if (textBox != null)
            {
                if (textBox == Autoren_Name)
                {
                    Autoren_Name.ForeColor = Color.White;
                    Autoren_Name.BackColor = Color.FromArgb(0);
                }


            }
        }


    }
}
