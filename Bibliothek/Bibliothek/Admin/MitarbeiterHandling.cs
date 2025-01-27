using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothek.Admin.MitarbeiterHandling
{
    public partial class MitarbeiterHandling : Form
    {
        public MitarbeiterHandling()
        {
            InitializeComponent();
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
    }
}
