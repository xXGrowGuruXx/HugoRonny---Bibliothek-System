using System.Data;
using Bibliothek.utils;
using OfficeOpenXml.Table;
using OfficeOpenXml;

namespace Bibliothek.Admin
{
    internal class ManageStatistik
    {
        public ManageStatistik() { }

        public void LoadStatistik(ComboBox comboBox, DataGridView grid, Button erstellen)
        {
            string selectedItem = comboBox.SelectedItem.ToString();

            if (selectedItem == "Bücher")
            {
                grid.Columns.Clear();

                DataTable bücher = Bücher();
                grid.DataSource = bücher;

                erstellen.Visible = false;
            }
            else if (selectedItem == "Strafen")
            {
                grid.Columns.Clear();

                DataTable strafen = Strafen();
                grid.DataSource = strafen;

                erstellen.Visible = false;
            }
            else if (selectedItem == "Nachrichten")
            {
                grid.Columns.Clear();

                DataTable nachrichten = Nachrichten();
                grid.DataSource = nachrichten;

                erstellen.Visible = false;
            }
            else if (selectedItem == "Reservierungen")
            {
                grid.Columns.Clear();

                DataTable reservierungen = Reservierung();
                grid.DataSource = reservierungen;

                erstellen.Visible = false;
            }
            else if (selectedItem == "Statistik erstellen")
            {
                grid.DataSource = null;

                grid.Columns.Add("Header", "                                                   Statistik erstellen");
                grid.Rows.Add("Klicke auf den Erstellen Button um die Statistik aller Einträge zu exportieren.");
                erstellen.Visible = true;
            }
        }

        private DataTable Bücher()
        {
            string query =
                    "SELECT Bücher.Titel, Autoren.AutorName, Genres.GenreName, BuchKopien.Anzahl " +
                    "FROM Bücher " +
                    "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                    "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                    "JOIN BuchKopien ON Bücher.BuchID = BuchKopien.BuchID";

            DataTable bücher = Database.ExecuteQuery(query);

            return bücher;
        }

        private DataTable Strafen()
        {
            string query =
                    "SELECT Bücher.Titel AS Buch, " +
                    "Benutzer.Vorname || ' ' || Benutzer.Name AS Kunde, " +
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
                    "JOIN Benutzer ON Ausgeliehen.BenutzerID = Benutzer.BenutzerID";

            DataTable strafen = Database.ExecuteQuery(query);

            return strafen;
        }

        private DataTable Reservierung()
        {
            string query =
                "SELECT Benutzer.Vorname || ' ' || Benutzer.Name AS Kunde, " +
                "Bücher.Titel, " +
                "Reservierungen.Reservierungsdatum " +
                "FROM Reservierungen " +
                "JOIN Bücher ON Reservierungen.BuchID = Bücher.BuchID " +
                "JOIN Benutzer ON Reservierungen.BenutzerID = Benutzer.BenutzerID";

            DataTable reservierungen = Database.ExecuteQuery(query);

            return reservierungen;
        }

        private DataTable Nachrichten()
        {
            string query =
                    "SELECT Benutzer.Vorname || ' ' || Benutzer.Name AS Kunde, " +
                    "Nachrichten.Nachricht, " +
                    "Nachrichten.AbsendeDatum " +
                    "FROM Nachrichten " +
                    "JOIN Benutzer ON Nachrichten.BenutzerID = Benutzer.BenutzerID";

            DataTable nachrichten = Database.ExecuteQuery(query);

            return nachrichten;
        }

        public void ExportStatistik()
        {
            DataTable bücher = Bücher();
            DataTable strafen = Strafen();
            DataTable nachrichten = Nachrichten();
            DataTable reservierungen = Reservierung();

            // SaveFileDialog verwenden
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Dateien (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Speicherort für die Statistik auswählen";
                saveFileDialog.FileName = "StatistikExport.xlsx";

                // Dialog anzeigen und prüfen, ob der Benutzer einen Speicherort gewählt hat
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    // Excel-Paket erstellen
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        // Tabelle "Bücher" hinzufügen
                        ExcelWorksheet sheetBücher = package.Workbook.Worksheets.Add("Bücher");
                        sheetBücher.Cells["A1"].LoadFromDataTable(bücher, true, TableStyles.Medium2);

                        // Tabelle "Strafen" hinzufügen
                        ExcelWorksheet sheetStrafen = package.Workbook.Worksheets.Add("Strafen");
                        sheetStrafen.Cells["A1"].LoadFromDataTable(strafen, true, TableStyles.Medium2);

                        // Tabelle "Nachrichten" hinzufügen
                        ExcelWorksheet sheetNachrichten = package.Workbook.Worksheets.Add("Nachrichten");
                        sheetNachrichten.Cells["A1"].LoadFromDataTable(nachrichten, true, TableStyles.Medium2);

                        // Tabelle "Nachrichten" hinzufügen
                        ExcelWorksheet sheetReservierungen = package.Workbook.Worksheets.Add("Reservierungen");
                        sheetReservierungen.Cells["A1"].LoadFromDataTable(reservierungen, true, TableStyles.Medium2);

                        // Datei speichern
                        FileInfo fileInfo = new FileInfo(filePath);
                        package.SaveAs(fileInfo);
                    }

                    MessageBox.Show($"Excel-Datei erfolgreich gespeichert unter:\n{filePath}", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Speichern abgebrochen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
