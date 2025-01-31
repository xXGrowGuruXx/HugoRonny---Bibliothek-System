using Bibliothek.utils;
using System.Data;

namespace Bibliothek.Mitarbeiter
{
    internal class ManageMenu
    {

        public void LoadBücher(ToolStripComboBox menuBox)
        {
            string query = "SELECT Titel FROM Bücher";

            // Datenbankabfrage ausführen
            DataTable result = Database.ExecuteQuery(query);

            if (result != null)
            {
                if (menuBox != null)
                {
                    menuBox.Items.Clear();

                    foreach (DataRow row in result.Rows) // Durch die Zeilen iterieren
                    {
                        menuBox.Items.Add(row["Titel"].ToString());
                    }
                }
            }
        }

        public void LoadAutoren(ToolStripMenuItem autorenMenu)
        {

        }

        public void LoadGenres(ToolStripMenuItem genreMenu)
        {

        }
    }
}
