using Bibliothek.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Mitarbeiter
{
    internal class ManageÜbersicht
    {
        public ManageÜbersicht()
        {

        }

        public void LoadGenres(ComboBox? comboBox)
        {
            string query = "SELECT GenreName FROM Genres";

            // Datenbankabfrage ausführen
            DataTable result = Database.ExecuteQuery(query);

            if (result != null && result.Rows.Count > 0)
            {
                if (comboBox != null)
                {
                    comboBox.Items.Clear(); // Nur einmal leeren, vor der Schleife
                    comboBox.Items.Add("* NEU *"); // Sonder-Eintrag hinzufügen

                    foreach (DataRow row in result.Rows) // Durch die Zeilen iterieren
                    {
                        comboBox.Items.Add(row["GenreName"].ToString());
                    }
                }
            }
        }

        public void CreateNewGenre(ComboBox comboBox, TextBox genreName)
        {
            string query =
                "INSERT INTO Genres(GenreName) " +
                "VALUES(@NewGenre)";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@NewGenre", genreName.Text)
            };

            try
            {
                Database.ExecuteQuery(query, parameters);
                MessageBox.Show("Neues Genre erfolgreich angelegt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                genreName.Text = string.Empty;
                LoadGenres(comboBox: comboBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim erstellen eines neuen Genres:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateGenre(TextBox genreName, ComboBox comboBox)
        {
            // Originalwerte aus der ComboBox
            string selectedGenre = comboBox.SelectedItem.ToString();

            // SQL-Update-Statement
            string query =
                "UPDATE Genres " +
                "SET GenreName = @NewName " +
                "WHERE GenreName = @CurrentName";

            // Parameter für die Abfrage
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@NewName", genreName.Text),
                new SQLiteParameter("@CurrentName", selectedGenre)
            };

            try
            {
                // Ausführen des Updates
                bool datenGeändert = Database.ExecuteNonQuery(query, parameters);

                // Rückmeldung an den Benutzer
                if (datenGeändert)
                {
                    MessageBox.Show("Genre erfolgreich aktualisiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (comboBox != null)
                    {
                        LoadGenres(comboBox: comboBox);
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen. Überprüfen Sie die Eingabewerte.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Genres:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAutoren(ComboBox comboBox)
        {
            string query = "SELECT AutorName FROM Autor";

            // Datenbankabfrage ausführen
            DataTable result = Database.ExecuteQuery(query);

            if (result != null && result.Rows.Count > 0)
            {
                if (comboBox != null)
                {
                    comboBox.Items.Clear(); // Nur einmal leeren, vor der Schleife
                    comboBox.Items.Add("* NEU *"); // Sonder-Eintrag hinzufügen
                }

                foreach (DataRow row in result.Rows) // Durch die Zeilen iterieren
                {
                    comboBox.Items.Add(row["AutorName"].ToString());
                }
            }
        }

        public void CreateNewAutor(ComboBox comboBox, TextBox autorName)
        {
            string query =
                "INSERT INTO Autoren(AutorName) " +
                "VALUES(@NewAutor)";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@NewAutor", autorName.Text)
            };

            try
            {
                Database.ExecuteQuery(query, parameters);
                MessageBox.Show("Neuer Autor erfolgreich angelegt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                autorName.Text = string.Empty;
                LoadAutoren(comboBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim erstellen eines neuen Autores:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateAutor(ComboBox comboBox, TextBox autorName)
        {
            // Originalwerte aus der ComboBox
            string selectedAutor = comboBox.SelectedItem.ToString();

            // SQL-Update-Statement
            string query =
                "UPDATE Autoren " +
                "SET AutorName = @NewName " +
                "WHERE AutorName = @CurrentName";

            // Parameter für die Abfrage
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@NewName", autorName.Text),
                new SQLiteParameter("@CurrentName", selectedAutor)
            };

            try
            {
                // Ausführen des Updates
                bool datenGeändert = Database.ExecuteNonQuery(query, parameters);

                // Rückmeldung an den Benutzer
                if (datenGeändert)
                {
                    MessageBox.Show("Autor erfolgreich aktualisiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGenres(comboBox: comboBox);
                }
                else
                {
                    MessageBox.Show("Es wurden keine Änderungen vorgenommen. Überprüfen Sie die Eingabewerte.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Autors:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
