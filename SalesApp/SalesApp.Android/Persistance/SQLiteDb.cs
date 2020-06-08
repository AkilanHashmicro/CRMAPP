using System;
using System.IO;
using SalesApp.Droid.Persistance;
using SalesApp.Persistance;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace SalesApp.Droid.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "MySQLite.db";
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentspath, filename);

            return new SQLiteConnection(path);
        }
    }
}