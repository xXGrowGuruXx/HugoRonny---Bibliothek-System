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
    public partial class AdminMain : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font logoutButton = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        private static AdminMain instance;

        public static AdminMain GetInstance()
        {
            return instance;
        }

        public AdminMain()
        {
            instance = this;
            InitializeComponent();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = Login.GetInstance();
            login.Show();
        }

        private void adminMain_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            adminMain_Name.Font = überschrift;
            adminMain_Mitarbeiter.Font = button;
            adminMain_Statistik.Font = button;
            adminMain_Logout.Font = logoutButton;
        }

        private void adminMain_Buttons_MouseEnter(object sender, EventArgs e)
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

        private void adminMain_Buttons_MouseLeave(object sender, EventArgs e)
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
