using Bibliothek.utils;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SQLite;

namespace Bibliothek.Mitarbeiter
{
    internal class ManageMenu
    {
        private static string buch;
        public void LoadBücher(ToolStripComboBox menuBox, TextBox titel, ComboBox autor, ComboBox genre, TextBox isbn)
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

                        menuBox.SelectedIndexChanged += (sender, e) =>
                        {
                            FillUI(titel, autor, genre, isbn, menuBox:  menuBox);
                            buch = menuBox.Text;
                        };
                    }
                }
            }
        }

        public void LoadAutoren(ToolStripMenuItem autorenMenu, TextBox titel, ComboBox autor, ComboBox genre, TextBox isbn)
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
                            ToolStripLabel label = new ToolStripLabel();
                            label.Text = bücherRow["Titel"].ToString();
                            label.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                            label.AutoSize = false;
                            label.Width = 350;

                            label.Click += (sender, e) =>
                            {
                                FillUI(titel, autor, genre, isbn, autorLabel:  label);
                                buch = label.Text;
                            };

                            menu.DropDownItems.Add(label);
                        }
                    }
                }
            }
        }

        public void LoadGenres(ToolStripMenuItem genreMenu, TextBox titel, ComboBox autor, ComboBox genre, TextBox isbn)
        {
            string genreQuery = "SELECT GenreName FROM Genres";

            DataTable genreResult = Database.ExecuteQuery(genreQuery);

            if (genreResult != null)
            {
                genreMenu.DropDownItems.Clear();

                foreach (DataRow genreRow in genreResult.Rows)
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    menu.Text = genreRow["GenreName"].ToString();
                    menu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    genreMenu.DropDownItems.Add(menu);

                    string bücherQuery =
                        "SELECT Titel " +
                        "FROM Bücher " +
                        "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                        "WHERE Genres.GenreName = @Name";

                    SQLiteParameter[] param =
                    {
                        new SQLiteParameter("@Name", genreRow["GenreName"].ToString())
                    };

                    DataTable bücherResult = Database.ExecuteQuery(bücherQuery, param);

                    if (bücherResult != null)
                    {
                        menu.DropDownItems.Clear();

                        foreach (DataRow bücherRow in bücherResult.Rows)
                        {
                            ToolStripLabel label = new ToolStripLabel();
                            label.Text = bücherRow["Titel"].ToString();
                            label.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                            label.AutoSize = false;
                            label.Width = 350;

                            label.Click += (sender, e) =>
                            {
                                FillUI(titel, autor, genre, isbn, genreLabel:  label);
                                buch = label.Text;
                            };

                            menu.DropDownItems.Add(label);
                        }
                    }
                }
            }
        }

        private void FillUI(TextBox titel, ComboBox autor, ComboBox genre, TextBox isbn, ToolStripComboBox? menuBox = null, ToolStripLabel? autorLabel = null, ToolStripLabel? genreLabel = null)
        {
            string selectedBuch = string.Empty;
            string findBuchQuery =
                "SELECT Bücher.Titel, Autoren.AutorName, Genres.GenreName, Bücher.ISBN " +
                "FROM Bücher " +
                "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                "WHERE Bücher.Titel = @Buch";

            List<SQLiteParameter> paramList = new List<SQLiteParameter>();

            if (menuBox != null)
            {
                selectedBuch = menuBox.Text;

                paramList.Add(new SQLiteParameter("@Buch", selectedBuch));
            }

            if (autorLabel != null)
            {
                selectedBuch = autorLabel.Text;

                paramList.Add(new SQLiteParameter("@Buch", selectedBuch));
            }

            if (genreLabel != null) 
            {
                selectedBuch = genreLabel.Text;

                paramList.Add(new SQLiteParameter("@Buch", selectedBuch));
            }

            SQLiteParameter[] param = paramList.ToArray();

            DataTable findBuchTable = Database.ExecuteQuery(findBuchQuery, param);

            foreach (DataRow buchRow in findBuchTable.Rows)
            {
                titel.Text = buchRow["Titel"].ToString();
                autor.SelectedItem = buchRow["AutorName"].ToString();
                genre.SelectedItem = buchRow["GenreName"].ToString();
                isbn.Text = buchRow["ISBN"].ToString();
            }
        }

        public void FillComboBoxes(ComboBox autor, ComboBox genre)
        {
            autor.Items.Clear();
            genre.Items.Clear();

            string autorQuery = "SELECT AutorName FROM Autoren";

            DataTable autorResult = Database.ExecuteQuery(autorQuery);

            if (autorResult != null)
            {
                foreach (DataRow autorRow in autorResult.Rows)
                {
                    if (!autor.Items.Contains(autorRow["AutorName"]))
                    {
                        autor.Items.Add(autorRow["AutorName"].ToString());
                    }
                }
            }

            string genreQuery = "SELECT GenreName FROM Genres";

            DataTable genreResult = Database.ExecuteQuery(genreQuery);

            if (genreResult != null)
            {
                foreach (DataRow genreRow in genreResult.Rows)
                {
                    if (!genre.Items.Contains(genreRow["GenreName"]))
                    {
                        genre.Items.Add(genreRow["GenreName"].ToString());
                    }
                }
            }
        }

        public void SaveChanges(TextBox title, ComboBox autor, ComboBox genre, TextBox ISBN)
        {
            string checkQuery =
                "SELECT Bücher.BuchID FROM Bücher " +
                "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                "WHERE Bücher.Titel = @Buch";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Buch", buch)
            };

            DataTable checkResult = Database.ExecuteQuery(checkQuery, param);

            if (checkResult.Rows.Count > 0)
            {
                // Update, wenn Buch existiert

                string updateQuery =
                    "UPDATE Bücher " +
                    "SET Titel = @Titel, AutorID = (SELECT AutorID FROM Autoren WHERE AutorName = @Autor), " +
                    "GenreID = (SELECT GenreID FROM Genres WHERE GenreName = @Genre), ISBN = @ISBN " +
                    "WHERE Titel = @Buch";

                SQLiteParameter[] updateParams =
                {
                    new SQLiteParameter("@Titel", title.Text),
                    new SQLiteParameter("@Autor", autor.SelectedItem?.ToString() ?? ""), // Sicherstellen, dass kein NULL-Wert übergeben wird
                    new SQLiteParameter("@Genre", genre.SelectedItem?.ToString() ?? ""),
                    new SQLiteParameter("@ISBN", ISBN.Text),
                    new SQLiteParameter("@Buch", buch) // Alter Titel für WHERE-Klausel
                };

                Database.ExecuteNonQuery(updateQuery, updateParams);

                MessageBox.Show("Bucheintrag erfolgreich geändert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Insert, wenn Buch nicht existiert

                string insertQuery =
                    "INSERT INTO Bücher (Titel, AutorID, GenreID, ISBN) " +
                    "VALUES (@Titel, (SELECT AutorID FROM Autoren WHERE AutorName = @Autor), " +
                    "(SELECT GenreID FROM Genres WHERE GenreName = @Genre), @ISBN)";

                SQLiteParameter[] insertParams =
                {
                    new SQLiteParameter("@Titel", title.Text),
                    new SQLiteParameter("@Autor", autor.SelectedItem?.ToString() ?? ""),
                    new SQLiteParameter("@Genre", genre.SelectedItem?.ToString() ?? ""),
                    new SQLiteParameter("@ISBN", ISBN.Text)
                };

                // Eingabe der Kopienanzahl mit Schleife
                int copies = 0;
                bool validInput = false;

                while (!validInput)
                {
                    string copiesInput = Microsoft.VisualBasic.Interaction.InputBox(
                        "Wieviele Kopien sind von dem Buch vorhanden?",
                        "Kopienanzahl",
                        "1"); // Standardwert ist 1

                    if (int.TryParse(copiesInput, out copies) && copies > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie eine gültige Zahl größer als 0 ein!", "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // Kopienanzahl speichern
                string insertCopiesQuery =
                    "INSERT INTO BuchKopien (BuchID, Anzahl) VALUES " +
                    "((SELECT BuchID FROM Bücher WHERE Titel = @Titel), @Anzahl)";

                SQLiteParameter[] copiesParams =
                {
                    new SQLiteParameter("@Titel", title.Text),
                    new SQLiteParameter("@Anzahl", copies)
                };

                Database.ExecuteNonQuery(insertQuery, insertParams);
                Database.ExecuteNonQuery(insertCopiesQuery, copiesParams);

                MessageBox.Show("Bucheintrag erfolgreich hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}