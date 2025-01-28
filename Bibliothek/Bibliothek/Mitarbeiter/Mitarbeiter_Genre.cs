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
    public partial class Mitarbeiter_Genre : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public Mitarbeiter_Genre()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Genre_Load(object sender, EventArgs e)
        {
            Genre_Seitenname.Font = überschrift;
            Genre_Label_Genre.Font = label;
            Genre_Name.Font = label;
            Genre_Speichern.Font = button;
            Genre_Zurueck.Font = button;
        }
        private void mitarbeiter_Genre(object sender, FormClosingEventArgs e)
        {
            MitarbeiterMain mitarbeiterMain = MitarbeiterMain.GetInstance();
            mitarbeiterMain.Show();
        }

        private void mitarbeiter_Genre_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_Genre_MouseEnter(object sender, EventArgs e)
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
                Genre_Auswahl_neu.ForeColor = Color.Black;
                Genre_Auswahl_neu.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == Genre_Name)
                {
                    Genre_Name.ForeColor = Color.Black;
                    Genre_Name.BackColor = Color.FromArgb(128, Color.White);
                }

            }
        }

        private void mitarbeiter_Genre_MouseLeave(object sender, EventArgs e)
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
                Genre_Auswahl_neu.ForeColor = Color.White;
                Genre_Auswahl_neu.BackColor = Color.FromArgb(0);
            }
            else if (textBox != null)
            {
                if (textBox == Genre_Name)
                {
                    Genre_Name.ForeColor = Color.White;
                    Genre_Name.BackColor = Color.FromArgb(0);
                }


            }
        }
    }
}
