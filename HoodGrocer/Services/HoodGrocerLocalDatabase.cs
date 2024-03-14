using HoodGrocer.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoodGrocer.Services
{
    public class HoodGrocerLocalDatabase
    {
        private SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "hoodgrocerdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        HoodGrocerLocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());

            _dbConnection.CreateTable<Client>();

        }

        public void SeedDatabase()
        {
            if (_dbConnection.Table<Client>().Count() == 0) 
            {
                Client client = new Client();
            }
        }

    }
        
}
