using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace HoodGrocer.Models
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ClientId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string IDNumber { get; set; }
        public string PhysicalAddress { get; set; }


        [ForeignKey(typeof(CartProduct))]
        public int CartID { get; set; } 
    }



}
