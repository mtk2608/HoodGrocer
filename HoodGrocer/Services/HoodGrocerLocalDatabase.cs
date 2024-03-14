using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;

namespace HoodGrocer.Services
{
    public class HoodGrocerLocalDatabase
    {
        private SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "hoodGrocer.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return Path.Combine(pathToDb, filename);
        }

        public HoodGrocerLocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());


        }
    }
}
