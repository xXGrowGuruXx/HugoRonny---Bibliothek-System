﻿using Bibliothek.utils;

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
            autoren_Seitenname.Font = überschrift;

            autoren_Label_Name.Font = label;

            autoren_Speichern.Font = button;
            autoren_Zurueck.Font = button;

            ManageÜbersicht manageÜbersicht = new ManageÜbersicht();
            manageÜbersicht.LoadAutoren(comboBox: autoren_List);
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
            TextBox? textBox = sender as TextBox;
            Button? button = sender as Button;

            if (button != null)
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == autoren_Name)
                {
                    autoren_Name.ForeColor = Color.Black;
                    autoren_Name.BackColor = Color.FromArgb(128, Color.White);
                }

            }
        }

        private void mitarbeiter_Autoren_MouseLeave(object sender, EventArgs e)
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
                if (textBox == autoren_Name)
                {
                    autoren_Name.ForeColor = Color.White;
                    autoren_Name.BackColor = Color.FromArgb(0);
                }
            }
        }

        private void autoren_Speichern_Click(object sender, EventArgs e)
        {
            if (autoren_Name != null)
            {
                ManageÜbersicht manageÜbersicht = new ManageÜbersicht();
                if (autoren_Name.Text == "* NEU *")
                {
                    manageÜbersicht.CreateNewAutor(autoren_List, autoren_Name);
                }
                else
                {
                    manageÜbersicht.UpdateAutor(autoren_List, autoren_Name);
                }
            }
        }
    }
}
