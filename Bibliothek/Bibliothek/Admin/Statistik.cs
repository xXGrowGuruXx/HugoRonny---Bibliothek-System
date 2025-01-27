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
    public partial class Statistik : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        public Statistik()
        {
            InitializeComponent();
        }

        private void Statistik_Load(object sender, EventArgs e)
        {
            statistik_Name.Font = überschrift;
            statistik_Label_Optionen.Font = label;
            statistik_Erstellen.Font = button;
            statistik_Abbrechen.Font = button;
        }

        private void statistik_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statistik_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain adminMain = AdminMain.GetInstance();
            adminMain.Show();
        }

        private void statistik_MouseEnter(object sender, EventArgs e)
        {
            // Casten des Senders zu einem Button
            Button? button = sender as Button;
            ComboBox? comboBox = sender as ComboBox;
            if (button != null)
            {
                // Ändere die Hintergrundfarbe des Buttons auf halbtransparent
                button.BackColor = Color.FromArgb(128, Color.White);
                button.ForeColor = Color.Black;
            }
            else if (comboBox != null)
            {
                // Ändere die Hintergrundfarbe des Labels auf halbtransparent
                statistik_Label_Optionen.BackColor = Color.FromArgb(128, Color.White);
                statistik_Label_Optionen.ForeColor = Color.Black;
            }
        }

        private void statistik_MouseLeave(object sender, EventArgs e)
        {
            // Casten des Senders zu einem Button
            Button? button = sender as Button;
            ComboBox comboBox = sender as ComboBox;
            if (button != null)
            {
                // Ändere die Hintergrundfarbe des Buttons auf halbtransparent
                button.BackColor = Color.FromArgb(0);
                button.ForeColor = Color.White;
            }
            else if (comboBox != null)
            {
                // Ändere die Hintergrundfarbe des Labels auf halbtransparent
                statistik_Label_Optionen.BackColor = Color.FromArgb(128, Color.White);
                statistik_Label_Optionen.ForeColor = Color.Black;
            }
        }
    }
}
