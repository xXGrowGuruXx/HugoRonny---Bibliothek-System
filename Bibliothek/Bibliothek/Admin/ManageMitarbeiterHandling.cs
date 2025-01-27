using System.Data;
using System.Data.SQLite;
using Bibliothek.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bibliothek.Admin
{
    internal class ManageMitarbeiterHandling
    {
        public ManageMitarbeiterHandling() { }

        public void LoadMitarbeiter(ComboBox comboBox)
        {
            string query = "SELECT Name || ', ' || Vorname AS FullName FROM Benutzer WHERE RollenID = 2";

            // Datenbankabfrage ausführen
            DataTable result = Database.ExecuteQuery(query);

            if (result != null && result.Rows.Count > 0)
            {
                comboBox.Items.Clear(); // Nur einmal leeren, vor der Schleife
                comboBox.Items.Add("* NEU *"); // Sonder-Eintrag hinzufügen

                foreach (DataRow row in result.Rows) // Durch die Zeilen iterieren
                {
                    comboBox.Items.Add(row["FullName"].ToString());
                }
            }
        }

        public void LoadSelectedInformation(ComboBox comboBox, TextBox forname, TextBox surename, TextBox username, TextBox passwort)
        {
            string selectedMitarbeiter = comboBox.SelectedItem.ToString();
            string[] parts = selectedMitarbeiter.Split(", ");
            string nachname = parts[0];
            string vorname = parts[1];

            // SQL-Abfrage mit Parametern
            string query = "SELECT * FROM Benutzer WHERE Name = @Nachname AND Vorname = @Vorname";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Nachname", nachname),
                new SQLiteParameter("@Vorname", vorname)
            };

            // Datenbankabfrage ausführen
            DataTable result = Database.ExecuteQuery(query, parameters);

            // Ergebnisse prüfen
            if (result != null && result.Rows.Count > 0)
            {
                // Werte aus der ersten Zeile holen
                DataRow row = result.Rows[0];
                forname.Text = row["Vorname"].ToString();
                surename.Text = row["Name"].ToString();
                username.Text = row["Username"].ToString();
                passwort.Text = row["Passwort"].ToString();
            }
            else
            {
                MessageBox.Show("Keine Daten gefunden.");
            }
        }

        public void CreateNewMitarbeiter(TextBox forname, TextBox surename, TextBox username, TextBox passwort)
        {
            string query =
                "INSERT INTO Benutzer(UserName, Name, Vorname, Passwort, RollenID) " +
                "VALUES(@Username, @Nachname, @Vorname, @Passwort, 2)";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Username", username.Text),
                new SQLiteParameter("@Nachname", surename.Text),
                new SQLiteParameter("@Vorname", forname.Text), 
                new SQLiteParameter("@Passwort", passwort.Text)
            };

            try
            {
                Database.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim erstellen eines neuen Mitarbeiters:\n" + ex.Message);
            }
        }
    }
}
