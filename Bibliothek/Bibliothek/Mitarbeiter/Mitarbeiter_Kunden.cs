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
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        private ManageKundenHandling manageKundenHandling;

        private static Mitarbeiter_Kunden instance;

        public static Mitarbeiter_Kunden GetInstance()
        {
            return instance;
        }

        public Mitarbeiter_Kunden()
        {
            instance = this;
            InitializeComponent();
            manageKundenHandling = new ManageKundenHandling();
        }

        private void Mitarbeiter_Kunden_Load(object sender, EventArgs e)
        {
            kunden_Seitenname.Font = überschrift;

            mitarbeiterKunden_Label_Name.Font = label;
            mitarbeiterKunden_Label_Username.Font = label;
            mitarbeiterKunden_Label_Vorname.Font = label;

            mitarbeiterKunden_Speichern.Font = button;
            mitarbeiterKunden_Info.Font = button;
            mitarbeiterKunden_Zurueck.Font = button;

            manageKundenHandling.LoadKunden(mitarbeiterKunden_List);
        }

        private void mitarbeiter_Kunden(object sender, FormClosingEventArgs e)
        {
            MitarbeiterMain mitarbeiterMain = MitarbeiterMain.GetInstance();
            mitarbeiterMain.Show();
        }

        private void mitarbeiter_Kunden_Zurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_Kunden_MouseEnter(object sender, EventArgs e)
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
                if (textBox == mitarbeiterKunden_Name)
                {
                    mitarbeiterKunden_Label_Name.ForeColor = Color.Black;
                    mitarbeiterKunden_Label_Name.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == mitarbeiterKunden_Username)
                {
                    mitarbeiterKunden_Label_Username.ForeColor = Color.Black;
                    mitarbeiterKunden_Label_Username.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == mitarbeiterKunden_Vorname)
                {
                    mitarbeiterKunden_Label_Vorname.ForeColor = Color.Black;
                    mitarbeiterKunden_Label_Vorname.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == mitarbeiterKunden_Passwort)
                {
                    mitarbeiterKunden_Label_Passwort.ForeColor = Color.Black;
                    mitarbeiterKunden_Label_Passwort.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }

        private void mitarbeiter_Kunden_MouseLeave(object sender, EventArgs e)
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
                if (textBox == mitarbeiterKunden_Name)
                {
                    mitarbeiterKunden_Label_Name.ForeColor = Color.White;
                    mitarbeiterKunden_Label_Name.BackColor = Color.FromArgb(0);
                }
                else if (textBox == mitarbeiterKunden_Username)
                {
                    mitarbeiterKunden_Label_Username.ForeColor = Color.White;
                    mitarbeiterKunden_Label_Username.BackColor = Color.FromArgb(0);
                }
                else if (textBox == mitarbeiterKunden_Vorname)
                {
                    mitarbeiterKunden_Label_Vorname.ForeColor = Color.White;
                    mitarbeiterKunden_Label_Vorname.BackColor = Color.FromArgb(0);
                }
                else if (textBox == mitarbeiterKunden_Passwort)
                {
                    mitarbeiterKunden_Label_Passwort.ForeColor = Color.Black;
                    mitarbeiterKunden_Label_Passwort.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }

        private void mitarbeiterKunden_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mitarbeiterKunden_List.Text != "* NEU *")
            {
                manageKundenHandling.LoadSelectedInformation(mitarbeiterKunden_List, mitarbeiterKunden_Vorname, mitarbeiterKunden_Name, mitarbeiterKunden_Username, mitarbeiterKunden_Passwort);
            }
            else
            {
                mitarbeiterKunden_Vorname.Text = string.Empty;
                mitarbeiterKunden_Name.Text = string.Empty;
                mitarbeiterKunden_Username.Text = string.Empty;
                mitarbeiterKunden_Passwort.Text = string.Empty;
            }
        }

        private void mitarbeiterKunden_Speichern_Click(object sender, EventArgs e)
        {
            if (mitarbeiterKunden_List.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Bitte wähle erst den Kunden oder * NEU *");
                return;
            }
            else if (mitarbeiterKunden_List.SelectedItem.ToString() == "* NEU *")
            {
                manageKundenHandling.CreateNewKunde(mitarbeiterKunden_List, mitarbeiterKunden_Vorname, mitarbeiterKunden_Name, mitarbeiterKunden_Username, mitarbeiterKunden_Passwort);
            }
            else
            {
                manageKundenHandling.UpdateKunde(mitarbeiterKunden_List, mitarbeiterKunden_Vorname, mitarbeiterKunden_Name, mitarbeiterKunden_Username, mitarbeiterKunden_Passwort);
            }
        }

        private void mitarbeiterKunden_Info_Click(object sender, EventArgs e)
        {
            Mitarbeiter_KundenInfo mitarbeiter_KundenInfo = new Mitarbeiter_KundenInfo(mitarbeiterKunden_List.Text);
            mitarbeiter_KundenInfo.Show();
            this.Hide();
        }
    }
}
