using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoodGrocer.Services;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace HoodGrocer.Item_Models
{
    public class BasicEssentials
    {

        [PrimaryKey, AutoIncrement]
        public int BasicEssentialsId { get; set; }

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemPrice { get; set; }



    }
}
