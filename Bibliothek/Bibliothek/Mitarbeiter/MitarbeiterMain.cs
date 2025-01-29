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
    public partial class MitarbeiterMain : Form
    {
        private static MitarbeiterMain instance;

        public static MitarbeiterMain GetInstance()
        { 
            return instance; 
        }

        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        public MitarbeiterMain()
        {
            instance = this;
            InitializeComponent();
        }

        private void MitarbeiterMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
        }

        private void mitarbeiter_Abmelden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mitarbeiter_Load(object sender, EventArgs e)
        {
            mitarbeiter_Name.Font = überschrift;
            mitarbeiter_Kunden.Font = button;
            mitarbeiter_Bücher.Font = button;
            mitarbeiter_Autoren.Font = button;
            mitarbeiter_Genres.Font = button;
            mitarbeiter_Abmelden.Font = button;
        }

        private void mitarbeiter_Buttons_MouseEnter(object sender, EventArgs e)
        {
            // Casten des Senders zu einem Button
            Button? button = sender as Button;
            if (button != null)
            {
                // Ändere die Hintergrundfarbe des Buttons auf halbtransparent
                button.BackColor = Color.FromArgb(128, Color.White);
                button.ForeColor = Color.Black;
            }
        }

        private void mitarbeiter_Buttons_MouseLeave(object sender, EventArgs e)
        {
            // Casten des Senders zu einem Button
            Button? button = sender as Button;
            if (button != null)
            {
                // Ändere die Hintergrundfarbe des Buttons auf halbtransparent
                button.BackColor = Color.FromArgb(0);
                button.ForeColor = Color.White;
            }
        }

        
    }
}
