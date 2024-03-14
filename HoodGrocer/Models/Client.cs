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

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; } 
            set {  emailAddress = value; } 
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
