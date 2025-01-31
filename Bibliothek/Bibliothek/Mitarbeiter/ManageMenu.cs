using Bibliothek.utils;
using System.Data;
using System.Data.SQLite;

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
            string autorQuery = "SELECT AutorName FROM Autoren";
            
            DataTable autorResult = Database.ExecuteQuery(autorQuery);

            if (autorResult != null )
            {
                autorenMenu.DropDownItems.Clear();

                foreach (DataRow autorRow in autorResult.Rows )
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    menu.Text = autorRow["AutorName"].ToString();
                    menu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    autorenMenu.DropDownItems.Add(menu);

                    string bücherQuery = 
                        "SELECT Titel " +
                        "FROM Bücher " +
                        "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                        "WHERE Autoren.AutorName = @Name";

                    SQLiteParameter[] param =
                    {
                        new SQLiteParameter("@Name", autorRow["AutorName"].ToString())
                    };

                    DataTable bücherResult = Database.ExecuteQuery(bücherQuery, param);

                    if (bücherResult != null)
                    {
                        menu.DropDownItems.Clear();

                        foreach (DataRow bücherRow in bücherResult.Rows)
                        {
                            ToolStripTextBox textBox = new ToolStripTextBox();
                            textBox.Text = bücherRow["Titel"].ToString();
                            textBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                            textBox.Width = 350;
                            textBox.AutoSize = false;
                            textBox.ReadOnly = true;
                            menu.DropDownItems.Add(textBox);
                        }
                    }
                }
            }
        }

        public void LoadGenres(ToolStripMenuItem genreMenu)
        {

        }
    }
}
