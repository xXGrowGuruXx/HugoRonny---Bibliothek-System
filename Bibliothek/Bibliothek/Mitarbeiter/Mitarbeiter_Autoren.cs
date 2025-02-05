using Bibliothek.utils;

namespace Bibliothek.Mitarbeiter
{
    public partial class Mitarbeiter_Autoren : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 28, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 20, FontStyle.Regular);

        public Mitarbeiter_Autoren()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Autoren_Load(object sender, EventArgs e)
        {
            autoren_Seitenname.Font = überschrift;

            autoren_Label_Name.Font = label;

            autoren_Speichern.Font = button;
            autoren_Zurueck.Font = button;

            ManageÜbersicht manageÜbersicht = new ManageÜbersicht();
            manageÜbersicht.LoadAutoren(autoren_List);
        }
        private void mitarbeiter_Autoren(object sender, FormClosingEventArgs e)
        {
            MitarbeiterMain mitarbeiterMain = MitarbeiterMain.GetInstance();
            mitarbeiterMain.Show();
        }

        private void mitarbeiter_Autoren_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_Autoren_MouseEnter(object sender, EventArgs e)
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
                if (textBox == autoren_Name)
                {
                    autoren_Label_Name.ForeColor = Color.Black;
                    autoren_Label_Name.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }

        private void mitarbeiter_Autoren_MouseLeave(object sender, EventArgs e)
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
                if (textBox == autoren_Name)
                {
                    autoren_Label_Name.ForeColor = Color.White;
                    autoren_Label_Name.BackColor = Color.FromArgb(0);
                }
            }
        }

        private void autoren_Speichern_Click(object sender, EventArgs e)
        {
            if (autoren_Name.Text != null)
            {
                ManageÜbersicht manageÜbersicht = new ManageÜbersicht();
                if (autoren_List.Text == "* NEU *")
                {
                    manageÜbersicht.CreateNewAutor(autoren_List, autoren_Name);
                }
                else
                {
                    manageÜbersicht.UpdateAutor(autoren_List, autoren_Name);
                }
            }
        }

        private void autoren_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoren_Name.Text = autoren_List.Text;
        }
    }
}
