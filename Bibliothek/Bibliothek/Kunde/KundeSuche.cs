using Bibliothek.Mitarbeiter;
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

namespace Bibliothek.Kunde
{
    public partial class KundeSuche : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        static KundeSuche instance;

        public static KundeSuche GetInstance()
        {
            return instance;
        }

        string _username = string.Empty;

        public KundeSuche(string userName)
        {
            _username = userName;
            instance = this;
            InitializeComponent();
        }
        private void KundeSuche_Load(object sender, EventArgs e)
        {
            KundeSuche_Seitenname.Font = überschrift;

            KundeSuche_Ausleihen.Font = button;
            KundeSuche_Reservieren.Font = button;
            KundeSuche_Zurück.Font = button;

            menu_Bücher.Font = button;
            menu_Autor.Font = button;
            menu_Genre.Font = button;
            menu_ISBN.Font = button;

            ManageSuche manageSuche = new ManageSuche();
            manageSuche.FillMenu(menu_Bücher, menu_Autor, menu_Genre, menu_ISBN, bücherSuche_Grid);
        }
        private void Kunde_Suche(object sender, FormClosingEventArgs e)
        {
            KundeMain kundeMain = KundeMain.GetInstance();
            kundeMain.Show();
        }

        private void Kunde_Suche_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kunde_Suche_MouseEnter(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;

            if (button != null)
            {
                button.ForeColor = Color.Black;
                button.BackColor = Color.FromArgb(128, Color.White);
            }
            else if (menuItem != null)
            {
                menuItem.ForeColor = Color.Black;
                menuItem.BackColor = Color.FromArgb(128, Color.White);
            }
        }

        private void Kunde_Suche_MouseLeave(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;

            if (button != null)
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(0);
            }
            else if (menuItem != null)
            {
                menuItem.ForeColor = Color.White;
                menuItem.BackColor = Color.FromArgb(0);
            }
        }

        private void KundeSuche_Ausleihen_Click(object sender, EventArgs e)
        {
            ManageSuche manageSuche = new ManageSuche();
            manageSuche.BuchAusleihen(bücherSuche_Grid, _username);
        }

        private void KundeSuche_Reservieren_Click(object sender, EventArgs e)
        {
            ManageSuche manageSuche = new ManageSuche();
            manageSuche.BuchReservieren(bücherSuche_Grid, _username);
        }
    }
}
