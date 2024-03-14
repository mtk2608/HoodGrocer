using System;
using HoodGrocer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;

namespace HoodGrocer.Services
{
    public class ItemsLocalDatabase
    {
        public SQLiteConnection itemConnection;

        public string GetDatabasePath()
        {
            string filepath = "itemsDatabase.db";
            string pathItem = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return Path.Combine(pathItem, filepath);
        }

        public ItemsLocalDatabase()
        {
            itemConnection = new SQLiteConnection(GetDatabasePath());

            itemConnection.CreateTable<Items>();

        }

        public void SeedItems()
        {
            if(itemConnection.Table<Items>().Count() == 0)
            {
                Items item = new Items()
                {
                    ItemName = "Sasko White Bread",
                    ItemPrice = ' ',
                    ItemQuantity = ' ',
                    ItemDescription = "20 Slice White Bread"
                };

                itemConnection.Insert(item);
            }
        }



    }
}
