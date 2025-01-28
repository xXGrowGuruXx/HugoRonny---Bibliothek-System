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

namespace Bibliothek.Admin
{
    public partial class MitarbeiterHandling : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public MitarbeiterHandling()
        {
            InitializeComponent();
        }

        private void MitarbeiterHandling_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain adminMain = AdminMain.GetInstance();
            adminMain.Show();
        }

        private void mitarbeiterHandling_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MitarbeiterHandling_Load(object sender, EventArgs e)
        {
            mitarbeiterHandling_Name.Font = überschrift;
            mitarbeiterHandling_Label_Choose.Font = label;
            mitarbeiterHandling_Label_Nachname.Font = label;
            mitarbeiterHandling_Label_Username.Font = label;
            mitarbeiterHandling_Label_Passwort.Font = label;
            mitarbeiterHandling_Löschen.Font = button;
            mitarbeiterHandling_Save.Font = button;
            mitarbeiterHandling_Abbrechen.Font = button;

            ManageMitarbeiterHandling manageMitarbeiterHandling = new ManageMitarbeiterHandling();
            manageMitarbeiterHandling.LoadMitarbeiter(mitarbeiterHandling_Choose);
        }

        private void mitarbeiterHandling_MouseEnter(object sender, EventArgs e)
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
                mitarbeiterHandling_Label_Choose.ForeColor = Color.Black;
                mitarbeiterHandling_Label_Choose.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == mitarbeiterHandling_Vorname)
                {
                    mitarbeiterHandling_Label_Vorname.ForeColor = Color.Black;
                    mitarbeiterHandling_Label_Vorname.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == mitarbeiterHandling_Nachname)
                {
                    mitarbeiterHandling_Label_Nachname.ForeColor = Color.Black;
                    mitarbeiterHandling_Label_Nachname.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == mitarbeiterHandling_Username)
                {
                    mitarbeiterHandling_Label_Username.ForeColor = Color.Black;
                    mitarbeiterHandling_Label_Username.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == mitarbeiterHandling_Passwort)
                {
                    mitarbeiterHandling_Label_Passwort.ForeColor = Color.Black;
                    mitarbeiterHandling_Label_Passwort.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }

        private void mitarbeiterHandling_MouseLeave(object sender, EventArgs e)
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
                mitarbeiterHandling_Label_Choose.ForeColor = Color.White;
                mitarbeiterHandling_Label_Choose.BackColor = Color.FromArgb(0);
            }
            else if (textBox != null)
            {
                if (textBox == mitarbeiterHandling_Vorname)
                {
                    mitarbeiterHandling_Label_Vorname.ForeColor = Color.White;
                    mitarbeiterHandling_Label_Vorname.BackColor = Color.FromArgb(0);
                }
                else if (textBox == mitarbeiterHandling_Nachname)
                {
                    mitarbeiterHandling_Label_Nachname.ForeColor = Color.White;
                    mitarbeiterHandling_Label_Nachname.BackColor = Color.FromArgb(0);
                }
                else if (textBox == mitarbeiterHandling_Username)
                {
                    mitarbeiterHandling_Label_Username.ForeColor = Color.White;
                    mitarbeiterHandling_Label_Username.BackColor = Color.FromArgb(0);
                }
                else if (textBox == mitarbeiterHandling_Passwort)
                {
                    mitarbeiterHandling_Label_Passwort.ForeColor = Color.White;
                    mitarbeiterHandling_Label_Passwort.BackColor = Color.FromArgb(0);
                }
            }
        }

        private void mitarbeiterHandling_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mitarbeiterHandling_Choose.SelectedItem.ToString() != "* NEU *")
            {
                ManageMitarbeiterHandling manageMitarbeiterHandling = new ManageMitarbeiterHandling();
                manageMitarbeiterHandling.LoadSelectedInformation(mitarbeiterHandling_Choose, mitarbeiterHandling_Vorname, mitarbeiterHandling_Nachname, mitarbeiterHandling_Username, mitarbeiterHandling_Passwort);
            }
            else
            {
                mitarbeiterHandling_Vorname.Text = string.Empty;
                mitarbeiterHandling_Nachname.Text = string.Empty;
                mitarbeiterHandling_Username.Text = string.Empty;
                mitarbeiterHandling_Passwort.Text = string.Empty;
            }
        }

        private void mitarbeiterHandling_Save_Click(object sender, EventArgs e)
        {
            ManageMitarbeiterHandling manageMitarbeiterHandling = new ManageMitarbeiterHandling();
            if (mitarbeiterHandling_Choose == null)
            {
                MessageBox.Show("Bitte wähle erst in der ComboBox was du tun möchtest!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mitarbeiterHandling_Choose.SelectedItem.ToString() == "* NEU *")
            {
                manageMitarbeiterHandling.CreateNewMitarbeiter(mitarbeiterHandling_Choose, mitarbeiterHandling_Vorname, mitarbeiterHandling_Nachname, mitarbeiterHandling_Username, mitarbeiterHandling_Passwort);
            }
            else
            {
                manageMitarbeiterHandling.UpdateMitarbeiter(mitarbeiterHandling_Choose, mitarbeiterHandling_Vorname, mitarbeiterHandling_Nachname, mitarbeiterHandling_Username, mitarbeiterHandling_Passwort);
            }
        }

        private void mitarbeiterHandling_Löschen_Click(object sender, EventArgs e)
        {
            if (mitarbeiterHandling_Choose.SelectedItem.ToString() != "* NEU *")
            {
                ManageMitarbeiterHandling manageMitarbeiterHandling = new ManageMitarbeiterHandling();
                manageMitarbeiterHandling.DeleteMitarbeiter(mitarbeiterHandling_Choose, mitarbeiterHandling_Vorname, mitarbeiterHandling_Nachname, mitarbeiterHandling_Username, mitarbeiterHandling_Passwort);
            }
            else if (string.IsNullOrEmpty(mitarbeiterHandling_Choose.SelectedItem.ToString()))
            {
                MessageBox.Show("Bitte wähle erst den Mitarbeiter den du Löschen möchtest!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
