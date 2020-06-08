using System;
using System.IO;
using SalesApp.Persistance;
using SQLite;

namespace SalesApp.iOS.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "MySQLite.db";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var librarypath = Path.Combine(documentspath, " ", "Library");
            var path = Path.Combine(librarypath, filename);

            return new SQLiteConnection(path);
        }
    }
}
