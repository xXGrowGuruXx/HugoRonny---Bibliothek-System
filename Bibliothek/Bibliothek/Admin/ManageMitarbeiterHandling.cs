using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
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

        public void CreateNewMitarbeiter(ComboBox comboBox, TextBox forname, TextBox surename, TextBox username, TextBox passwort)
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
                MessageBox.Show("Neuer Mitarbeiter erfolgreich angelegt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                forname.Text = string.Empty;
                surename.Text = string.Empty;
                username.Text = string.Empty;
                passwort.Text = string.Empty;
                LoadMitarbeiter(comboBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim erstellen eines neuen Mitarbeiters:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateMitarbeiter(ComboBox comboBox, TextBox forname, TextBox surename, TextBox username, TextBox passwort)
        {
            // Originalwerte aus der ComboBox
            string selectedMitarbeiter = comboBox.SelectedItem.ToString();

            // SQL-Update-Statement
            string query =
                "UPDATE Benutzer " +
                "SET UserName = @Username, Name = @Nachname, Vorname = @Vorname, Passwort = @Passwort " +
                "WHERE Name || ', ' || Vorname = @FullName";

            // Parameter für die Abfrage
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Username", username.Text),
                new SQLiteParameter("@Nachname", surename.Text),
                new SQLiteParameter("@Vorname", forname.Text),
                new SQLiteParameter("@Passwort", passwort.Text),
                new SQLiteParameter("@FullName", selectedMitarbeiter),
            };

            try
            {
                // Ausführen des Updates
                bool datenGeändert = Database.ExecuteNonQuery(query, parameters);

                // Rückmeldung an den Benutzer
                if (datenGeändert)
                {
                    MessageBox.Show("Mitarbeiter erfolgreich aktualisiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMitarbeiter(comboBox);
                }
                else
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen. Überprüfen Sie die Eingabewerte.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Mitarbeiters:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteMitarbeiter(ComboBox comboBox, TextBox forname, TextBox surename, TextBox username, TextBox passwort)
        {
            string selectedMitarbeiter = comboBox.SelectedItem.ToString();
            string[] parts = selectedMitarbeiter.Split(", ");
            string nachname = parts[0];
            string vorname = parts[1];

            // SQL-Delete-Statement
            string query =
                "DELETE FROM Benutzer " +
                "WHERE Name = @Nachname AND Vorname = @Vorname";

            // Parameter für die Abfrage
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Nachname", nachname),
                new SQLiteParameter("@Vorname", vorname),
            };

            try
            {
                // Ausführen des Updates
                bool datenGeändert = Database.ExecuteNonQuery(query, parameters);

                // Rückmeldung an den Benutzer
                if (datenGeändert)
                {
                    MessageBox.Show("Mitarbeiter erfolgreich gelöscht!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    forname.Text = string.Empty;
                    surename.Text = string.Empty;
                    username.Text = string.Empty;
                    passwort.Text = string.Empty;
                    LoadMitarbeiter(comboBox);
                }
                else
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen. Überprüfen Sie die Eingabewerte.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim löschen des Mitarbeiters:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
