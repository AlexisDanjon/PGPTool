using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using PGPTool.Data;
using System.IO;
using Xamarin.Forms;
using PGPTool.iOS.Data;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace PGPTool.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var filename = "Menna.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;

        }
    }
}