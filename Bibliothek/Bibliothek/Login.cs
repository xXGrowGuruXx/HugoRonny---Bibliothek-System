using Bibliothek.utils;
using System.Data.SQLite;
using System.Data;
using System.Media;
using Bibliothek.Admin;
using Bibliothek.Mitarbeiter;
using Bibliothek.Kunde;

namespace Bibliothek
{
    public partial class Login : Form
    {
        /// <summary>
        /// Instance der LoginForm
        /// </summary>
        /// <param name="instance">Speichert die Aktuelle Form als Instance</param>
        /// <param name="GetInstance">Holt die Instance und arbeitet mit ihr</param>
        private static Login instance;
        public static Login GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// Custom Fonts
        /// </summary>
        static Font �berschrift = CustomFonts.GetCustomFont("Vacaciones", 24, FontStyle.Regular);
        static Font label = CustomFonts.GetCustomFont("Vacaciones", 14, FontStyle.Regular);
        static Font button = CustomFonts.GetCustomFont("Vacaciones", 18, FontStyle.Regular);
        public Login()
        {
            instance = this;
            InitializeComponent();
        }

        /// <summary>
        /// Login Form Schriftarten zuweisen
        /// </summary>
        private void Login_Load(object sender, EventArgs e)
        {
            login_Name.Font = �berschrift;
            login_Label_Username.Font = label;
            login_Label_Password.Font = label;
            login_Login.Font = button;
            login_RememberMe.Font = label;
        }

        /// <summary>
        /// Login Button Click
        /// </summary>
        /// <param name="username">Nimmt den eingegebenen Username</param>
        /// <param name="password">Nimmt des eingegebenes Password</param>
        /// <param name="query">Die Query f�r die Datenbank</param>
        /// <param name="parameters">�bergibt Username und Password an die Query, um SQL-Injection zu verhindern</param>
        /// <param name="result">Empf�ngt das Ergebnis der Datenbank</param>
        /// <param name="rollenID">Pr�ft welche Rolle der User hat</param>
        private void login_Login_Click(object sender, EventArgs e)
        {
            string username = login_Username.Text;
            string password = login_Password.Text;

            // SQL-Abfrage, um zu pr�fen, ob der Benutzername und das Passwort �bereinstimmen
            string query = "SELECT RollenID FROM Benutzer WHERE UserName = @username AND Passwort = @password";

            // Parameter f�r die SQL-Abfrage
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@username", username),
                new SQLiteParameter("@password", password)
            };

            // F�hre die Abfrage aus und erhalte das Ergebnis
            DataTable result = Database.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                // Wenn ein Ergebnis zur�ckgegeben wurde, pr�fe die RollenID
                int rollenID = Convert.ToInt32(result.Rows[0]["RollenID"]);

                // Verwende ein Switch-Case, um die RollenID zu �berpr�fen und den entsprechenden Wert zur�ckzugeben
                switch (rollenID)
                {
                    case 1:
                        // Rolle 1 - Admin
                        AdminMain adminMain = new AdminMain();
                        adminMain.Show();
                        this.Hide();
                        break;

                    case 2:
                        // Rolle 2 - Mitarbeiter
                        MitarbeiterMain mitarbeiter = new MitarbeiterMain();
                        mitarbeiter.Show();
                        this.Hide();
                        break;

                    case 3:
                        // Rolle 3 - Kunde
                        KundeMain kunden = new KundeMain(username);
                        kunden.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                // Wenn der Benutzername oder das Passwort falsch ist
                MessageBox.Show("Benutzername oder Passwort ung�ltig.");
            }
        }

        private void login_Login_MouseEnter(object sender, EventArgs e)
        {
            login_Login.BackColor = Color.FromArgb(128, Color.White);
            login_Login.ForeColor = Color.Black;
        }

        private void login_Login_MouseLeave(object sender, EventArgs e)
        {
            login_Login.BackColor = Color.FromArgb(0);
            login_Login.ForeColor = Color.White;
        }
    }
}
