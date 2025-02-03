using Bibliothek.utils;

namespace Bibliothek.Mitarbeiter
{
    public partial class Mitarbeiter_Buecher : Form
    {
        static Font überschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 16, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);

        public Mitarbeiter_Buecher()
        {
            InitializeComponent();
        }

        private void mitarbeiter_Buecher_Closing(object sender, FormClosingEventArgs e)
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

            bücher_Label_Titel.Font = label;
            bücher_Label_Autor.Font = label;
            bücher_Label_Genre.Font = label;
            bücher_Label_ISBN.Font = label;

            buecher_Speichern.Font = button;
            buecher_Zurueck.Font = button;

            ManageMenu manageMenu = new ManageMenu();
            manageMenu.LoadBücher(menu_Bücher, bücher_Titel, bücher_Autor, bücher_Genre, bücher_ISBN);
            manageMenu.LoadAutoren(menu_Autoren, bücher_Titel, bücher_Autor, bücher_Genre, bücher_ISBN);
            manageMenu.LoadGenres(menu_Genre, bücher_Titel, bücher_Autor, bücher_Genre, bücher_ISBN);
        }

        private void mitarbeiter_Bücher_MouseEnter(object sender, EventArgs e)
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
                if (comboBox == bücher_Autor)
                {
                    bücher_Label_Autor.ForeColor = Color.Black;
                    bücher_Label_Autor.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (comboBox == bücher_Genre)
                {
                    bücher_Label_Genre.ForeColor = Color.Black;
                    bücher_Label_Genre.BackColor = Color.FromArgb(128, Color.White);
                }
            }
            else if (textBox != null)
            {
                if (textBox == bücher_Titel)
                {
                    bücher_Label_Titel.ForeColor = Color.Black;
                    bücher_Label_Titel.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (textBox == bücher_ISBN)
                {
                    bücher_Label_ISBN.ForeColor = Color.Black;
                    bücher_Label_ISBN.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }


        private void mitarbeiter_Bücher_MouseLeave(object sender, EventArgs e)
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
                if (comboBox == bücher_Autor)
                {
                    bücher_Label_Autor.ForeColor = Color.White;
                    bücher_Label_Autor.BackColor = Color.FromArgb(0);
                }
                else if (comboBox == bücher_Genre)
                {
                    bücher_Label_Genre.ForeColor = Color.White;
                    bücher_Label_Genre.BackColor = Color.FromArgb(0);
                }
            }
            else if (textBox != null)
            {
                if (textBox == bücher_Titel)
                {
                    bücher_Label_Titel.ForeColor = Color.White;
                    bücher_Label_Titel.BackColor = Color.FromArgb(0);
                }
                else if (textBox == bücher_ISBN)
                {
                    bücher_Label_ISBN.ForeColor = Color.White;
                    bücher_Label_ISBN.BackColor = Color.FromArgb(0);
                }
            }
        }

        private void bücher_Menu_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem? menu = sender as ToolStripMenuItem;

            if (menu != null)
            {
                if (menu == menu_Bücher)
                {
                    menu_Bücher.ForeColor = Color.Black;
                    menu_Bücher.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (menu == menu_Autoren)
                {
                    menu_Autoren.ForeColor = Color.Black;
                    menu_Autoren.BackColor = Color.FromArgb(128, Color.White);
                }
                else if (menu == menu_Genre)
                {
                    menu_Genre.ForeColor = Color.Black;
                    menu_Genre.BackColor = Color.FromArgb(128, Color.White);
                }
            }
        }

        private void bücher_Menu_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem? menu = sender as ToolStripMenuItem;

            if (menu != null)
            {
                if (menu == menu_Bücher)
                {
                    menu_Bücher.ForeColor = Color.White;
                    menu_Bücher.BackColor = Color.FromArgb(0);
                }
                else if (menu == menu_Autoren)
                {
                    menu_Autoren.ForeColor = Color.White;
                    menu_Autoren.BackColor = Color.FromArgb(0);
                }
                else if (menu == menu_Genre)
                {
                    menu_Genre.ForeColor = Color.White;
                    menu_Genre.BackColor = Color.FromArgb(0);
                }
            }
        }

        private void buecher_Speichern_Click(object sender, EventArgs e)
        {
            ManageMenu manageMenu = new ManageMenu();
            manageMenu.SaveChanges(bücher_Titel, bücher_Autor, bücher_Genre, bücher_ISBN);
        }

        private void TextBox_Changed(object sender, EventArgs e)
        {
            ManageMenu manualMenu = new ManageMenu();
            manualMenu.FillComboBoxes(bücher_Autor, bücher_Genre);
        }
    }
}
