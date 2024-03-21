using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoodGrocer.Models
{
    public class CartProduct
    {
        [PrimaryKey, AutoIncrement]
        public int CartId { get; set; } 
     
        public int Quantity { get; set; }
        public decimal CartTotal { get; set; }
        public string CartName { get; set; }
        public string CartImage { get; set; }


        [ForeignKey(typeof(Product))]
        public int ItemsId { get; set; } 

        [ForeignKey(typeof(Client))]
        public int ClientId { get; set; }

        // Relationships
        [OneToOne]
        public Client Client{ get; set; }
    }
}
