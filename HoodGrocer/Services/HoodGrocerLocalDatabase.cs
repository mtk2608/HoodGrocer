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

            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "hoodGrocer.db");

            return databasePath;
        }

        public HoodGrocerLocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());

            _dbConnection.CreateTable<Client>();
            _dbConnection.CreateTable<Product>();

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

            if (_dbConnection.Table<Product>().Count() == 0)
            {
                List<Product> products = new List<Product>()
                {
                    new Product()
                {
                    ItemImage = "caesar.jpeg",
                    ItemName = "Caesar Pop Cigarettes",
                    ItemDescription = "Carton of 10 Packets",
                    ItemPrice = 200,
                    ItemQuantity = "20"
                },

                 new Product()
                 {
                     ItemImage = "airpop.jpeg",
                     ItemName = "Airpop Orange",
                     ItemDescription = "Disposable smoking device",
                     ItemPrice = 100,
                     ItemQuantity = "100"
                 },

                 new Product()
                 {
                     ItemImage = "strawberryairpop.jpeg",
                     ItemName = "Strawberry Airpop",
                     ItemDescription = "Disposable smoking device",
                     ItemPrice = 100,
                     ItemQuantity = "100"
                 },

                 new Product()
                 {
                     ItemImage = "daybreakerbread.jpeg",
                     ItemName = "Daybreaker Bread",
                     ItemDescription = "20 Large Slice White Bread",
                     ItemPrice = 10,
                     ItemQuantity = "20"
                 },

                 new Product()
                 {
                     ItemImage = "saskowhitebread.jpeg",
                     ItemName = "Sasko Sam White Bread",
                     ItemDescription = "20 Large Slice Premium White Bread",
                     ItemPrice = 18,
                     ItemQuantity = "20"
                 },

                 new Product()
                 {
                     ItemImage = "flour.jpeg",
                     ItemName = "Sasko Sam White Flour",
                     ItemDescription = "Sasko Cake Wheat Flour is ideally suited for baking cakes, bread and other baked goods which require cake what flour. Cake wheat flour is produced by removing the wheat kernels' layer of germ and bran and grinding the leftover endosperm into flour. Cake flour is whiter in colour than white bread flour and is regarded as far superior.\r\n\r\nProduct Information:\r\nHalaal\r\nKosher\r\nSuitable for vegetarians\r\n2.5kg.",
                     ItemPrice = 90,
                     ItemQuantity = "30"
                 },

                 new Product()
                 {
                     ItemImage = "hulletsugar.jpeg",
                     ItemName = "Huletts White Sugar",
                     ItemDescription = "2.5kg White Sugar",
                     ItemPrice = 70,
                     ItemQuantity = "20"
                 },

                 new Product()
                 {
                     ItemImage = "hulletsugar.jpeg",
                     ItemName = "Huletts White Sugar",
                     ItemDescription = "250g White Sugar",
                     ItemPrice = 20,
                     ItemQuantity = "20"
                 },

                 new Product()
                 {
                     ItemImage = "milk.jpeg",
                     ItemName = "Alfalfa Milk",
                     ItemDescription = "1 Litre Sachet",
                     ItemPrice = 12,
                     ItemQuantity = "20"
                 },

                 new Product()
                 {
                     ItemImage = "yogisip.jpeg",
                     ItemName = "Alfalfa Drinkable Yoghurt",
                     ItemDescription = "500ml Drinkable Yoghurt",
                     ItemPrice = 10,
                     ItemQuantity = "20"
                 },

                 new Product()
                 {
                     ItemImage = "gosloschilli.jpeg",
                     ItemName = "Goslos Chilli",
                     ItemDescription = "Chips",
                     ItemPrice = 5,
                     ItemQuantity = "100"
                 },

                 new Product()
                 {
                     ItemImage = "goslosperiperi.jpeg",
                     ItemName = "Goslos Peri Peri",
                     ItemDescription = "Chips",
                     ItemPrice = 5,
                     ItemQuantity = "100"
                 }
                };
                _dbConnection.Insert(products);

            }
        }

        public List<Product> GetAllItems()
        {
            return _dbConnection.Table<Product>().ToList();
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
