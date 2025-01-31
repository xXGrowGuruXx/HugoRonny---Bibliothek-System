using Bibliothek.utils;
using System.Data;
using System.Data.SQLite;

namespace Bibliothek.Mitarbeiter
{
    internal class ManageKundenHandling
    {
        public ManageKundenHandling() { }

        public void LoadKunden(ComboBox comboBox)
        {
            string query = "SELECT Name || ', ' || Vorname AS FullName FROM Benutzer WHERE RollenID = 3";

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
            string selectedKunde = comboBox.SelectedItem.ToString();
            string[] parts = selectedKunde.Split(", ");
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

        public void CreateNewKunde(ComboBox comboBox, TextBox forname, TextBox surename, TextBox username, TextBox passwort)
        {
            string query =
                "INSERT INTO Benutzer(UserName, Name, Vorname, Passwort, RollenID) " +
                "VALUES(@Username, @Nachname, @Vorname, @Passwort, 3)";

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
                MessageBox.Show("Neuer Kunde erfolgreich angelegt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                forname.Text = string.Empty;
                surename.Text = string.Empty;
                username.Text = string.Empty;
                passwort.Text = string.Empty;
                LoadKunden(comboBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim erstellen eines neuen Kundens:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateKunde(ComboBox comboBox, TextBox forname, TextBox surename, TextBox username, TextBox passwort)
        {
            // Originalwerte aus der ComboBox
            string selectedKunde = comboBox.SelectedItem.ToString();

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
                new SQLiteParameter("@FullName", selectedKunde),
            };

            try
            {
                // Ausführen des Updates
                bool datenGeändert = Database.ExecuteNonQuery(query, parameters);

                // Rückmeldung an den Benutzer
                if (datenGeändert)
                {
                    MessageBox.Show("Kunde erfolgreich aktualisiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKunden(comboBox);
                }
                else
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen. Überprüfen Sie die Eingabewerte.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Kundes:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
