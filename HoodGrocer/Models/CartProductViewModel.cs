using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoodGrocer.Models
{
    public class CartProductViewModel : BindableObject
    {
        /*

        public decimal TotalPrice => CartProducts.Sum(items => items.Product.ItemPrice * items.Quantity);

        public void AddItem(Product product)
        {
            var existingItem = CartProducts.FirstOrDefault(items => items.Product.ItemName == product.ItemName);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                CartProducts.Add(new CartProduct { Product = product, Quantity = 1 });
            }
            OnPropertyChanged(nameof(TotalPrice));
        }

        public void RemoveItem(CartProduct items)
        {
            CartProducts.Remove(items);
            OnPropertyChanged(nameof(TotalPrice));
        }*/
    }
}
