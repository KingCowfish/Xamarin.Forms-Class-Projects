using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ContactBook.Persistence;
using Foundation;
using SQLite;
using UIKit;

namespace SQLiteContactBook.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}