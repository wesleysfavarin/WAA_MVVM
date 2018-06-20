using System;
using System.IO;
using SQLite;
using WAA_MVVM.Data;
using WAA_MVVM.iOS;
using Xamarin.Forms;
[assembly: Dependency(typeof(SQLite_ios))]
namespace WAA_MVVM.iOS
{
    public class SQLite_ios : ISQLite
    {
        public SQLite_ios()
        {
        }

        public SQLiteConnection GetConnection(string dbName)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, "..", "Library", dbName);
            return new SQLiteConnection(path);

        }
    }
}
