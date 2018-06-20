using System;
using WAA_MVVM.Data;
using WAA_MVVM.Droid;
using Xamarin.Forms;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(SQLite_droid))]
namespace WAA_MVVM.Droid
{
    public class SQLite_droid : ISQLite
    {
        public SQLite_droid()
        {
        }

        public SQLiteConnection GetConnection(string dbName)
        {
            var documents = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, dbName);
            return new SQLiteConnection(path);
        }

    }
}
