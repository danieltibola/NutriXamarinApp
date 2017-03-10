using TibolaNutricao.Data;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using Xamarin.Forms;
using TibolaNutricao.iOS;

[assembly: Dependency(typeof(SQLite_ios))]
namespace TibolaNutricao.iOS
{
    public class SQLite_ios : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "Refeicoes.db3";
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, "..", "Library", fileName);

            return new SQLiteConnection(path);
        }
    }
}
