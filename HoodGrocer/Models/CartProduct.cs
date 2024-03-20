using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoodGrocer.Models
{
    public class CartProduct
    {
        public Product Product { get; set; } 
        public int Quantity { get; set; }
    }
}
