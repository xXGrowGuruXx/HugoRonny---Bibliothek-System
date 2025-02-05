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
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        public Mitarbeiter_Genre()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Genre_Load(object sender, EventArgs e)
        {
            Genre_Seitenname.Font = überschrift;

            genre_Label_Name.Font = label;

            Genre_Speichern.Font = button;
            Genre_Zurueck.Font = button;

            ManageÜbersicht manageÜbersicht = new ManageÜbersicht();
            manageÜbersicht.LoadGenres(comboBox: genre_Auswahl);
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
            TextBox? textBox = sender as TextBox;
            Button? button = sender as Button;

            if (button != null)
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == genre_Name)
                {
                    genre_Label_Name.ForeColor = Color.Black;
                    genre_Label_Name.BackColor = Color.FromArgb(128, Color.White);
                }

            }
        }

        private void mitarbeiter_Genre_MouseLeave(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            Button? button = sender as Button;

            if (button != null)
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(0);
            }
            else if (textBox != null)
            {
                if (textBox == genre_Name)
                {
                    genre_Label_Name.ForeColor = Color.White;
                    genre_Label_Name.BackColor = Color.FromArgb(0);
                }


            }
        }

        private void Genre_Speichern_Click(object sender, EventArgs e)
        {
            if (genre_Name.Text != null)
            {
                ManageÜbersicht manageÜbersicht = new ManageÜbersicht();
                if (genre_Auswahl.Text == "* NEU *")
                {
                    manageÜbersicht.CreateNewGenre(genre_Auswahl, genre_Name);
                }
                else
                {
                    manageÜbersicht.UpdateGenre(genre_Name, comboBox: genre_Auswahl);
                }
            }
        }

        private void genre_Auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre_Name.Text = genre_Auswahl.Text;
        }
    }
}
