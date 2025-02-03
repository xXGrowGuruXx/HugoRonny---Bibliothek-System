using Bibliothek.utils;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Bibliothek.Kunde
{
    internal class ManageSuche
    {
        public ManageSuche() { }

        public void FillMenu(ToolStripMenuItem bücher, ToolStripMenuItem autor, ToolStripMenuItem genre, ToolStripMenuItem isbn, DataGridView grid)
        {
            string bücherQuery = "SELECT Titel FROM Bücher";

            DataTable bücherResult = Database.ExecuteQuery(bücherQuery);

            if (bücherResult != null)
            {
                bücher.DropDownItems.Clear();

                foreach (DataRow bücherRow in bücherResult.Rows)
                {
                    ToolStripLabel label = new ToolStripLabel();
                    label.Text = bücherRow["Titel"].ToString();
                    label.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    label.AutoSize = false;
                    label.Width = 350;

                    label.Click += (sender, e) =>
                    {
                        FillDataGrid(grid, label.Text);
                    };

                    bücher.DropDownItems.Add(label);
                }
            }


            string autorQuery = "SELECT AutorName FROM Autoren";

            DataTable autorResult = Database.ExecuteQuery(autorQuery);

            if (autorResult != null)
            {
                autor.DropDownItems.Clear();

                foreach (DataRow autorRow in autorResult.Rows)
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    menu.Text = autorRow["AutorName"].ToString();
                    menu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    autor.DropDownItems.Add(menu);

                    bücherQuery =
                        "SELECT Titel " +
                        "FROM Bücher " +
                        "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                        "WHERE Autoren.AutorName = @Name";

                    SQLiteParameter[] param =
                    {
                        new SQLiteParameter("@Name", autorRow["AutorName"].ToString())
                    };

                    bücherResult = Database.ExecuteQuery(bücherQuery, param);

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
                                FillDataGrid(grid, label.Text);
                            };

                            menu.DropDownItems.Add(label);
                        }
                    }
                }
            }

            string genreQuery = "SELECT GenreName FROM Genres";

            DataTable genreResult = Database.ExecuteQuery(genreQuery);

            if (genreResult != null)
            {
                genre.DropDownItems.Clear();

                foreach (DataRow genreRow in genreResult.Rows)
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    menu.Text = genreRow["GenreName"].ToString();
                    menu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    genre.DropDownItems.Add(menu);

                    bücherQuery =
                        "SELECT Titel " +
                        "FROM Bücher " +
                        "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                        "WHERE Genres.GenreName = @Name";

                    SQLiteParameter[] param =
                    {
                        new SQLiteParameter("@Name", genreRow["GenreName"].ToString())
                    };

                    bücherResult = Database.ExecuteQuery(bücherQuery, param);

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
                                FillDataGrid(grid, label.Text);
                            };

                            menu.DropDownItems.Add(label);
                        }
                    }
                }
            }

            string isbnQuery = "SELECT ISBN FROM Bücher";

            DataTable isbnResult = Database.ExecuteQuery(isbnQuery);

            if (isbnResult != null)
            {
                isbn.DropDownItems.Clear();

                foreach (DataRow isbnRow in isbnResult.Rows)
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    menu.Text = isbnRow["ISBN"].ToString();
                    menu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    isbn.DropDownItems.Add(menu);

                    bücherQuery =
                        "SELECT Titel " +
                        "FROM Bücher " +
                        "WHERE ISBN = @ISBN";

                    SQLiteParameter[] param =
                    {
                        new SQLiteParameter("@ISBN", isbnRow["ISBN"].ToString())
                    };

                    bücherResult = Database.ExecuteQuery(bücherQuery, param);

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
                                FillDataGrid(grid, label.Text);
                            };

                            menu.DropDownItems.Add(label);
                        }
                    }
                }
            }
        }

        private void FillDataGrid(DataGridView grid, string buchName)
        {
            string query =
                "SELECT Bücher.Titel, Autoren.AutorName, Genres.GenreName, Bücher.ISBN " +
                "FROM Bücher " +
                "JOIN Autoren ON Bücher.AutorID = Autoren.AutorID " +
                "JOIN Genres ON Bücher.GenreID = Genres.GenreID " +
                "WHERE Bücher.Titel = @Buch";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Buch", buchName)
            };

            DataTable result = Database.ExecuteQuery(query, param);

            if (result != null)
            {
                grid.DefaultCellStyle.ForeColor = Color.Black;
                grid.DataSource = result;

                foreach (DataRow row in result.Rows)
                {
                    query =
                        "SELECT COUNT(Ausgeliehen.BuchID) AS Ausleihen " +
                        "FROM Bücher " +
                        "JOIN Ausgeliehen ON Bücher.BuchID = Ausgeliehen.BuchID " +
                        "WHERE Bücher.Titel = @Buch " +
                        "AND Ausgeliehen.Rückgabe != 1";

                    DataTable result2 = Database.ExecuteQuery(query, param);

                    if (result2 != null && result2.Rows.Count > 0)
                    {
                        foreach (DataRow row2 in result2.Rows)
                        {
                            int ausgeliehendeBücher = int.Parse(row2["Ausleihen"].ToString());

                            query =
                                "SELECT BuchKopien.Anzahl AS Vorhanden " +
                                "FROM Bücher " +
                                "JOIN BuchKopien ON Bücher.BuchID = BuchKopien.BuchID " +
                                "WHERE Bücher.Titel = @Buch ";

                            DataTable result3 = Database.ExecuteQuery(query, param);

                            if (result3 != null && result3.Rows.Count > 0)
                            {
                                foreach (DataRow row3 in result3.Rows)
                                {
                                    int vorhandeneKopien = int.Parse(row3["Vorhanden"].ToString());

                                    KundeSuche kundeSuche = KundeSuche.GetInstance();

                                    if (ausgeliehendeBücher < vorhandeneKopien)
                                    {
                                        kundeSuche.KundeSuche_Ausleihen.Visible = true;
                                        kundeSuche.KundeSuche_Reservieren.Visible = false;
                                    }
                                    else
                                    {
                                        kundeSuche.KundeSuche_Reservieren.Visible = true;
                                        kundeSuche.KundeSuche_Ausleihen.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void BuchAusleihen(DataGridView grid, string username)
        {
            string query = "SELECT BenutzerID FROM Benutzer WHERE Benutzer.UserName = @Username";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", username),
            };

            DataTable userResult = Database.ExecuteQuery(query, param);

            int userID = 0;

            foreach (DataRow user in userResult.Rows)
            {
                userID = int.Parse(user["BenutzerID"].ToString());
            }

            if (userID > 0)
            {
                DataTable table = (DataTable)grid.DataSource;

                foreach (DataRow row1 in table.Rows)
                {
                    string buch = row1["Titel"].ToString();

                    query = "SELECT BuchID FROM Bücher WHERE Bücher.Titel = @Titel";

                    SQLiteParameter[] param2 =
                    {
                        new SQLiteParameter("@Titel", buch)
                    };

                    DataTable buchResult = Database.ExecuteQuery(query, param2);

                    int buchID = 0;

                    foreach (DataRow row2 in buchResult.Rows)
                    {
                        buchID = int.Parse(row2["BuchID"].ToString());
                    }

                    if (buchID > 0)
                    {
                        string ausleihDatum = DateTime.Today.ToString("yyyy-MM-dd");
                        string rückgabeDatum = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");

                        query =
                            "INSERT INTO Ausgeliehen (BuchID, BenutzerID, AusleihDatum, RückgabeDatum) " +
                            "VALUES (@Buch, @User, @Ausleih, @Rückgabe)";

                        SQLiteParameter[] param3 =
                        {
                            new SQLiteParameter("Buch", buchID),
                            new SQLiteParameter("@User", userID),
                            new SQLiteParameter("@Ausleih", ausleihDatum),
                            new SQLiteParameter("@Rückgabe", rückgabeDatum)
                        };

                        bool inserted = Database.ExecuteNonQuery(query, param3);

                        if (inserted)
                        {
                            MessageBox.Show($"Du hast das Buch {buch} erfolgreich ausgeliehen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Beim ausleihen vom Buch {buch} ist etwas schiefgelaufen.\nBitte wende dich an einen Mitarbeiter.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. UserID konnte nicht gefunden werden.");
            }
        }

        public void BuchReservieren(DataGridView grid, string username)
        {
            string query = "SELECT BenutzerID FROM Benutzer WHERE Benutzer.UserName = @Username";

            SQLiteParameter[] param =
            {
                new SQLiteParameter("@Username", username),
            };

            DataTable userResult = Database.ExecuteQuery(query, param);

            int userID = 0;

            foreach (DataRow user in userResult.Rows)
            {
                userID = int.Parse(user["BenutzerID"].ToString());
            }

            if (userID > 0)
            {
                DataTable table = (DataTable)grid.DataSource;

                foreach (DataRow row1 in table.Rows)
                {
                    string buch = row1["Titel"].ToString();

                    query = "SELECT BuchID FROM Bücher WHERE Bücher.Titel = @Titel";

                    SQLiteParameter[] param2 =
                    {
                        new SQLiteParameter("@Titel", buch)
                    };

                    DataTable buchResult = Database.ExecuteQuery(query, param2);

                    int buchID = 0;

                    foreach (DataRow row2 in buchResult.Rows)
                    {
                        buchID = int.Parse(row2["BuchID"].ToString());
                    }

                    if (buchID > 0)
                    {
                        string reservierungsDatum = DateTime.Today.ToString("yyyy-MM-dd");

                        query =
                            "INSERT INTO Reservierungen (BuchID, BenutzerID, Reservierungsdatum) " +
                            "VALUES (@Buch, @User, @Reservierung)";

                        SQLiteParameter[] param3 =
                        {
                            new SQLiteParameter("Buch", buchID),
                            new SQLiteParameter("@User", userID),
                            new SQLiteParameter("@Reservierung", reservierungsDatum)
                        };

                        bool inserted = Database.ExecuteNonQuery(query, param3);

                        if (inserted)
                        {
                            MessageBox.Show($"Du hast das Buch {buch} erfolgreich reserviert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Beim reservieren vom Buch {buch} ist etwas schiefgelaufen.\nBitte wende dich an einen Mitarbeiter.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. UserID konnte nicht gefunden werden.");
            }
        }
    }
}