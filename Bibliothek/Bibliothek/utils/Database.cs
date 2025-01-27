using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Bibliothek.utils
{
    internal class Database
    {
        private static SQLiteConnection _connection;

        /// <summary>
        /// Initialisiert die Verbindung zur SQLite-Datenbank.
        /// </summary>
        /// <param name="stream">Läd die eingebettete Datenbank aus der EXE</param>
        /// <param name="exeDirectory">Sucht den Pfad der EXE</param>
        /// <param name="databaseFilePath">Legt den Pfad fest, wo die Datenbank gespeichert werden soll</param>
        /// <param name="fileStream">Speichert die Datenbank</param>
        public static void LoadDatabase()
        {
            // Hole den Stream der eingebetteten Ressource
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Bibliothek.Resources.BiblioDB.db"))
            {
                if (stream == null)
                {
                    throw new ArgumentException("Die Datenbank-Ressource konnte nicht gefunden werden.");
                }

                // Bestimme den Ordner, in dem die EXE ausgeführt wird
                string exeDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                // Erstelle den Pfad für die Datenbankdatei im gleichen Verzeichnis wie die EXE
                string databaseFilePath = Path.Combine(exeDirectory, "BiblioDB.db");

                // Schreibe den Inhalt des Streams in die Datei
                using (var fileStream = new FileStream(databaseFilePath, FileMode.Create, FileAccess.Write))
                {
                    stream.CopyTo(fileStream);
                }

                // Verwende den Pfad zur gespeicherten Datei für die Verbindung
                _connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;");
            }
        }

        /// <summary>
        /// Führt ein SQL-Query aus und gibt die Ergebnisse zurück.
        /// </summary>
        /// <param name="query">Das SQL-Query.</param>
        /// <param name="parameters">Optionale Parameter für das Query um SQL Injections zu verhindern.</param>
        /// <returns>Ein DataTable mit den Ergebnissen (nur für SELECT).</returns>
        public static DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("Die Datenbankverbindung wurde nicht initialisiert. Rufen Sie LoadDatabase() zuerst auf.");
            }

            using (var command = new SQLiteCommand(query, _connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        /// <summary>
        /// Führt ein SQL-Query aus, das keine Ergebnisse zurückgibt (z. B. INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">Das SQL-Query.</param>
        /// <param name="parameters">Optionale Parameter für das Query.</param>
        public static void ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("Die Datenbankverbindung wurde nicht initialisiert. Rufen Sie LoadDatabase() zuerst auf.");
            }

            _connection.Open();
            try
            {
                using (var command = new SQLiteCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
