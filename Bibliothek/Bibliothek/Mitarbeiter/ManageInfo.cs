using Bibliothek.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bibliothek.Mitarbeiter
{
    internal class ManageInfo
    {
        public ManageInfo() { }

        public void LoadInfo(ComboBox comboBox, DataGridView grid, string userName)
        {
            string selectedItem = comboBox.SelectedItem.ToString();

            if (selectedItem == "Ausgeliehen")
            {
                DataTable bücher = Bücher(userName);
                grid.DataSource = bücher;

            }
            else if (selectedItem == "Strafen")
            {
                DataTable strafen = Strafen(userName);
                grid.DataSource = strafen;

            }
            else if (selectedItem == "Reservierungen")
            {
                DataTable reservierungen = Reservierung(userName);
                grid.DataSource = reservierungen;
            }
        }

        private DataTable Bücher(string username)
        {
            string query =
                    "SELECT Bücher.Titel, Autoren.AutorName, Genres.GenreName, Ausgeliehen.Ausleihdatum, Ausgeliehen.Rückgabedatum, Ausgeliehen.Rückgabe " +
                    "FROM Ausgeliehen " +
                    "JOIN Bücher ON Ausgeliehen.BuchID = Bücher.BuchID " +
                    "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                    "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                    "JOIN Benutzer ON Ausgeliehen.BenutzerID = Benutzer.BenutzerID " +
                    "WHERE Benutzer.UserName = @Username";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Username", username)
            };

            DataTable bücher = Database.ExecuteQuery(query, parameters);

            return bücher;
        }

        private DataTable Strafen(string username)
        {
            string query =
                    "SELECT Bücher.Titel AS Buch, " +
                    "Strafen.StrafDatum, " +
                    "Strafen.ZahlDatum, " +
                    "Strafen.Betrag, " +
                    "CASE " +
                    "    WHEN Strafen.Bezahlt = 1 THEN 'true' " +
                    "    WHEN Strafen.Bezahlt = 0 THEN 'false' " +
                    "    WHEN Strafen.Bezahlt IS NULL THEN ' ' " +
                    "END AS Bezahlt, " +
                    "CASE " +
                    "    WHEN Ausgeliehen.Rückgabe = 1 THEN 'true' " +
                    "    WHEN Ausgeliehen.Rückgabe = 0 THEN 'false' " +
                    "    WHEN Ausgeliehen.Rückgabe IS NULL THEN ' ' " +
                    "END AS Rückgabe " +
                    "FROM Strafen " +
                    "JOIN Ausgeliehen ON Strafen.AusleihID = Ausgeliehen.AusleihID " +
                    "JOIN Bücher ON Ausgeliehen.BuchID = Bücher.BuchID " +
                    "JOIN Benutzer ON Ausgeliehen.BenutzerID = Benutzer.BenutzerID " +
                    "WHERE Benutzer.UserName = @Username";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", username)
            };

            DataTable strafen = Database.ExecuteQuery(query);

            return strafen;
        }

        private DataTable Reservierung(string username)
        {
            string query =
                "SELECT Bücher.Titel, " +
                "Reservierungen.Reservierungsdatum " +
                "FROM Reservierungen " +
                "JOIN Bücher ON Reservierungen.BuchID = Bücher.BuchID " +
                "JOIN Benutzer ON Reservierungen.BenutzerID = Benutzer.BenutzerID " +
                "WHERE Benutzer.UserName = @Username";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", username)
            };

            DataTable reservierungen = Database.ExecuteQuery(query);

            return reservierungen;
        }
    }
}
