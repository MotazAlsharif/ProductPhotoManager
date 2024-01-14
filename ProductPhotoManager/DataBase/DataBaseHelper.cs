using System;
using Microsoft.Data.Sqlite;

namespace ProductPhotoManager.DataBase
{
    public class DataBaseHelper
    {
        private readonly string _dbPath;

        public DataBaseHelper(string dbPath)
        {
            _dbPath = dbPath;
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection($"Data Source ={_dbPath}"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    @"
                    CREATE TABLE IF NOT EXISTS Photos(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ImagePath TEXT,
                        Annotation TEXT
                    );
                    ";
                command.ExecuteNonQuery();
            }
        }
    }
}
