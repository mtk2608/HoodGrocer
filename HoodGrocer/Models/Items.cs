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
        public string ItemImage {  get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string ItemQuantity { get; set; }
        public string ItemDescription { get; set; }

    }
}
