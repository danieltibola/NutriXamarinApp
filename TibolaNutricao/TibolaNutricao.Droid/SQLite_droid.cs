using TibolaNutricao.Data;
using SQLite;
using Xamarin.Forms;
using TibolaNutricao.Droid;
using System.IO;

[assembly: Dependency(typeof(SQLite_droid))]
namespace TibolaNutricao.Droid
{
    class SQLite_droid : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "Refeicoes.db3";

            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);

            return connection;
        }
    }
}