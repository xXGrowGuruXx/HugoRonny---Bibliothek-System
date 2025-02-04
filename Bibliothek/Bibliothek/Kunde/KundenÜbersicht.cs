using Bibliothek.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.Kunde
{
    internal class KundenÜbersicht
    {
        string _username = string.Empty;
        public KundenÜbersicht(string username) 
        { 
            _username = username;
        }

        public void ShowBücher(DataGridView grid)
        {
            string query =
                "SELECT Bücher.Titel, Ausgeliehen.Ausleihdatum, Ausgeliehen.Rückgabedatum AS 'Rückgabe am'" +
                "FROM Ausgeliehen " +
                "JOIN Benutzer ON Ausgeliehen.BenutzerID = Benutzer.BenutzerID " +
                "JOIN Bücher ON Ausgeliehen.BuchID = Bücher.BuchID " +
                "WHERE Benutzer.UserName = @Username " +
                "AND Ausgeliehen.Rückgabe != 1";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", _username)
            };

            DataTable result = Database.ExecuteQuery(query, param);

            if (result != null)
            {
                grid.DataSource = result;
            }
        }

        public void LoadBücher(ComboBox comboBox, DataGridView grid)
        {
            comboBox.Items.Clear();

            foreach (DataGridViewRow row in grid.Rows)
            {
                comboBox.Items.Add(row.Cells["Titel"].Value?.ToString());
            }
        }

        public void BuchAbgeben(ComboBox comboBox, DataGridView grid)
        {
            // Prüfen, ob unbezahlte Strafen existieren
            string checkQuery =
                "SELECT COUNT(*) AS Strafen " +
                "FROM Ausgeliehen " +
                "JOIN Benutzer ON Ausgeliehen.BenutzerID = Benutzer.BenutzerID " +
                "JOIN Bücher ON Ausgeliehen.BuchID = Bücher.BuchID " +
                "JOIN Strafen ON Ausgeliehen.AusleihID = Strafen.AusleihID " +
                "WHERE Benutzer.UserName = @Username " +
                "AND Bücher.Titel = @BuchTitel " +
                "AND Strafen.Bezahlt != 1";

            SQLiteParameter[] checkParam =
            {
                new SQLiteParameter("@Username", _username),
                new SQLiteParameter("@BuchTitel", comboBox.Text)
            };

            DataTable checkResult = Database.ExecuteQuery(checkQuery, checkParam);

            if (checkResult != null && checkResult.Rows.Count > 0)
            {
                int strafenCount = Convert.ToInt32(checkResult.Rows[0]["Strafen"]);

                if (strafenCount > 0)
                {
                    MessageBox.Show("Zahle bitte erst deine Strafen!", "Strafe offen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Falls keine Strafen vorhanden sind, Buch zurückgeben
            string query =
                "UPDATE Ausgeliehen " +
                "SET Rückgabe = 1 " +
                "WHERE BenutzerID = (SELECT BenutzerID FROM Benutzer WHERE UserName = @Username) " +
                "AND BuchID = (SELECT BuchID FROM Bücher WHERE Titel = @BuchTitel) ";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", _username),
                new SQLiteParameter("@BuchTitel", comboBox.Text)
            };

            bool done = Database.ExecuteNonQuery(query, param);

            if (done)
            {
                MessageBox.Show("Buch erfolgreich zurückgegeben.");
                ShowBücher(grid);
                LoadBücher(comboBox, grid);
            }
            else
            {
                MessageBox.Show("Fehler bei der Buchrückgabe. Bitte wende dich an einen Mitarbeiter!");
            }
        }

        public void ShowStrafen(DataGridView grid)
        {
            string query =
                "SELECT Bücher.Titel, Ausgeliehen.Ausleihdatum AS 'Ausgeliehen am', Ausgeliehen.Rückgabedatum AS 'Rückgabe am', Strafen.StrafDatum AS 'Strafe seid', Strafen.Betrag " +
                "FROM Ausgeliehen " +
                "JOIN Benutzer ON Ausgeliehen.BenutzerID = Benutzer.BenutzerID " +
                "JOIN Bücher ON Ausgeliehen.BuchID = Bücher.BuchID " +
                "JOIN Strafen ON Ausgeliehen.AusleihID = Strafen.AusleihID " +
                "WHERE Benutzer.UserName = @Username " +
                "AND Ausgeliehen.Rückgabe != 1 " +
                "AND Strafen.Bezahlt != 1";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", _username)
            };

            DataTable result = Database.ExecuteQuery(query, param);

            if (result != null)
            {
                grid.DataSource = result;

                // Formatierung der Spalte "Betrag" mit €-Symbol
                grid.Columns["Betrag"].DefaultCellStyle.Format = "C2"; // C2 = Währung mit 2 Nachkommastellen
                grid.Columns["Betrag"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("de-DE");
            }
        }

        public void LoadStrafen(ComboBox comboBox, DataGridView grid)
        {
            comboBox.Items.Clear();

            foreach (DataGridViewRow row in grid.Rows)
            {
                comboBox.Items.Add(row.Cells["Titel"].Value?.ToString());
            }
        }

        public void StrafeZahlen(ComboBox comboBox, DataGridView grid)
        {
            string query =
                "UPDATE Strafen " +
                "SET Bezahlt = 1, Zahldatum = DATE('now', 'localtime') " +
                "WHERE AusleihID IN ( " +
                    "SELECT AusleihID FROM Ausgeliehen " +
                    "WHERE BenutzerID = (SELECT BenutzerID FROM Benutzer WHERE UserName = @Username) " +
                    "AND BuchID = (SELECT BuchID FROM Bücher WHERE Titel = @BuchTitel) " +
                ")";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", _username),
                new SQLiteParameter("@BuchTitel", comboBox.Text)
            };

            bool done = Database.ExecuteNonQuery(query, param);

            if (done)
            {
                MessageBox.Show("Strafe erfolgreich bezahlt.");
                ShowStrafen(grid);
                LoadStrafen(comboBox, grid);
            }
            else
            {
                MessageBox.Show("Fehler beim bezahlen der Strafe. Bitte wende dich an einen Mitarbeiter!");
            }
        }

        public void ShowReservierung(DataGridView grid)
        {
            string query =
                "SELECT Bücher.Titel, Reservierungen.Reservierungsdatum " +
                "FROM Reservierungen " +
                "JOIN Bücher ON Reservierungen.BuchID = Bücher.BuchID " +
                "JOIN Benutzer ON Reservierungen.BenutzerID = Benutzer.BenutzerID " +
                "WHERE Benutzer.UserName = @Username";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", _username)
            };

            DataTable result = Database.ExecuteQuery(query, param);

            if (result != null)
            {
                grid.DataSource = result;
            }
        }

        public void LoadReservierung(ComboBox comboBox, DataGridView grid)
        {
            comboBox.Items.Clear();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row != null)
                {
                    comboBox.Items.Add(row.Cells["Titel"].Value?.ToString());
                }
            }
        }

        public void RemoveReservierung(ComboBox comboBox, DataGridView grid)
        {
            string query =
                "DELETE FROM Reservierungen " +
                "WHERE BuchID = (SELECT BuchID FROM Bücher WHERE Titel = @BuchTitel) " +
                "AND BenutzerID = (SELECT BenutzerID FROM Benutzer WHERE UserName = @Username)";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", _username),
                new SQLiteParameter("@BuchTitel", comboBox.Text)
            };

            bool done = Database.ExecuteNonQuery(query, param);

            if (done)
            {
                MessageBox.Show("Reservierung erfolgreich entfernt.");
                ShowReservierung(grid);
                LoadReservierung(comboBox, grid);
            }
            else
            {
                MessageBox.Show("Fehler beim Entfernen der Reservierung. Bitte wende dich an einen Mitarbeiter!");
            }
        }
    }
}
