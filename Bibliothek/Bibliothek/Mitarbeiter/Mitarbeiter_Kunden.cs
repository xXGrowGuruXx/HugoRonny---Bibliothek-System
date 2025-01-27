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
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public Mitarbeiter_Kunden()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Name_Click(object sender, EventArgs e)
        {

        }

        private void Mitarbeiter_Kunden_Load(object sender, EventArgs e)
        {
            kunden_Seitenname.Font = überschrift;
            kunden_Label_Name.Font = label;
            kunden_Label_Username.Font = label;
            kunden_Label_Vorname.Font = label;
            kunden_Label_Strasse.Font = label;
            kunden_Label_Ort.Font = label;
            kunden_Label_PLZ.Font = label;
            kunden_Username.Font = label;
            kunden_Name.Font = label;
            kunden_Vorname.Font= label;
            kunden_Strasse.Font= label;
            kunden_Ort.Font= label;
            kunden_PLZ.Font= label;
            kunden_Speichern.Font = button;
            kunden_deaktivieren.Font = button;
            kunden_Ausgeliehen.Font = button;
            kunden_Reservierungen.Font = button;
            kunden_Zurueck.Font = button;
        }
    }
}
