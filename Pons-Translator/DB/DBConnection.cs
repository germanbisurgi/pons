
using Mk.DBConnector;

namespace Pons_Translator.DB
{
    class DBConnection
    {
        public static DBAdapter db;

        static DBConnection()
        {
            db = new DBAdapter(DatabaseType.MySql, Instance.Singleton, "localhost", 3306, "pons_translator", "root", "", "pons_translator.log");
            db.Adapter.LogFile = true;
        }
    }
}
