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
    public partial class Mitarbeiter_KundenInfo : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        static string _username = string.Empty;

        public Mitarbeiter_KundenInfo(string username)
        {
            _username = username;

            InitializeComponent();

            kundenInfo_Name.Font = überschrift;
            kundenInfo_Zurück.Font = button;
        }

        private void kundenInfo_Zurück_MouseEnter(object sender, EventArgs e)
        {
            kundenInfo_Zurück.ForeColor = Color.Black;
            kundenInfo_Zurück.BackColor = Color.FromArgb(128, Color.White);
        }

        private void kundenInfo_Zurück_MouseLeave(object sender, EventArgs e)
        {
            kundenInfo_Zurück.ForeColor = Color.White;
            kundenInfo_Zurück.BackColor = Color.FromArgb(0);
        }

        private void kundenInfo_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageInfo manageInfo = new ManageInfo();
            manageInfo.LoadInfo(kundenInfo_Options, kundenInfo_Grid, _username);
        }

        private void kundenInfo_Zurück_Click(object sender, EventArgs e)
        {
            Mitarbeiter_Kunden mitarbeiter_Kunden = Mitarbeiter_Kunden.GetInstance();
            mitarbeiter_Kunden.Show();
            this.Close();
        }
    }
}
