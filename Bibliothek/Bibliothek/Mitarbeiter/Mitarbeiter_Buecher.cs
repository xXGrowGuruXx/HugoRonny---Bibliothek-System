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
    public partial class Mitarbeiter_Buecher : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public Mitarbeiter_Buecher()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Buecher(object sender, FormClosingEventArgs e)
        {
            MitarbeiterMain mitarbeiterMain = MitarbeiterMain.GetInstance();
            mitarbeiterMain.Show();
        }

        private void mitarbeiter_Buecher_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mitarbeiter_Buecher_Load(object sender, EventArgs e)
        {
            buch_Seitenname.Font = überschrift;
            buecher_Label_Titel.Font = label;
            buecher_Label_Autor.Font = label;
            buecher_Label_Genre.Font = label;
            buecher_Label_ISBN.Font = label;
            buecher_Titel.Font = label;
            buecher_Autor.Font = label;
            buecher_Genre.Font = label;
            buecher_ISBN.Font = label;
            buecher_Speichern.Font = button;
            buecher_Loeschen.Font = button;
            buecher_Zurueck.Font = button;


        }
        private void mitarbeiter_Buecher_MouseEnter(object sender, EventArgs e)
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
                buecher_Titel_Autor.ForeColor = Color.Black;
                buecher_Titel_Autor.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (textBox != null)
            {
                if (textBox == buecher_Titel)
                {
                    buecher_Titel.ForeColor = Color.Black;
                    buecher_Titel.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == buecher_Autor)
                {
                    buecher_Autor.ForeColor = Color.Black;
                    buecher_Autor.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == buecher_Genre)
                {
                    buecher_Genre.ForeColor = Color.Black;
                    buecher_Genre.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == buecher_ISBN)
                {
                    buecher_ISBN.ForeColor = Color.Black;
                    buecher_ISBN.BackColor = Color.FromArgb(128, Color.White);
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
                buecher_Titel_Autor.ForeColor = Color.White;
                buecher_Titel_Autor.BackColor = Color.FromArgb(0);
            }
            else if (textBox != null)
            {
                if (textBox == buecher_Titel)
                {
                    buecher_Titel.ForeColor = Color.White;
                    buecher_Titel.BackColor = FromArgb(0);
                }
                else if (textBox == buecher_Autor)
                {
                    buecher_Autor.ForeColor = Color.White;
                    buecher_Autor.BackColor = FromArgb(0);
                }
                else if (textBox == buecher_Genre)
                {
                    buecher_Genre.ForeColor = Color.White;
                    buecher_Genre.BackColor = FromArgb(0);
                }
                else if (textBox == buecher_ISBN)
                {
                    buecher_ISBN.ForeColor = Color.White;
                    buecher_ISBN.BackColor = FromArgb(0);
                }

            }
        }
    }
}
