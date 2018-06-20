using System;
using SQLite;

namespace WAA_MVVM.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(string dbName);
    }
}
