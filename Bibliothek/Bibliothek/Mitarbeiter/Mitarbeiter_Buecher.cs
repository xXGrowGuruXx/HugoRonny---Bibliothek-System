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

        private void login_Label_Username_Click(object sender, EventArgs e)
        {

        }

        private void Mitarbeiter_Buecher_Load(object sender, EventArgs e)
        {
            buch_Seitenname.Font = überschrift;
            buecher_Label_Titel.Font = label;
            buecher_Label_Autor.Font = label;
            buecher_Label_Genre.Font = label;
            buecher_Label_ISBN.Font = label;
            buecher_Titel.Font= label;
            buecher_Autor.Font= label;
            buecher_Genre.Font= label;
            buecher_ISBN.Font= label;
            buecher_Speichern.Font = button;
            buecher_Loeschen.Font= button;
            buecher_Zurueck.Font= button;


        }
    }
}
