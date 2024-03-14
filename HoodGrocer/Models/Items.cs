using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoodGrocer.Models
{
    public class Items
    {
        [PrimaryKey, AutoIncrement]
        public int ItemsId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
        public string ItemDescription { get; set; }

    }
}
