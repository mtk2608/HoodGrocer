using HoodGrocer.Models;
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
        public SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "hoodGrocer.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return Path.Combine(pathToDb, filename);
        }

        public HoodGrocerLocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());

            _dbConnection.CreateTable<Client>();

            SeedDatabase();
        }

        public void SeedDatabase()
        {
            if (_dbConnection.Table<Client>().Count() == 0) 
            {
                Client client = new Client()
                {
                    Name = "Tayieb",
                    Surname = "Kamaldien",
                    ContactNumber = "012823737483",
                    EmailAddress = "tayieb@gmail.com",
                    Password = "tayieb11",
                    Gender = "Male",
                    DateofBirth = DateTime.Now,
                    IDNumber = "022100020222",
                    PhysicalAddress = "%@ fgdjfnfdohgdfcvnblckjh"
                };

                _dbConnection.Insert(client);
            }
        }

        public void UpdateClient(Client client)
        {
            _dbConnection.Update(client);
        }

        public Client GetClientById(int id)
        {
            Client client = _dbConnection.Table<Client>().Where(x => x.ClientId == id).FirstOrDefault();

            if (client != null)
                _dbConnection.GetChildren(client, true);

            return client;
        }

    }
        
}
