using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoodGrocer.Models
{

    public class ItemsViewModel
    {
        public ObservableCollection<Items> Items { get; set; }
        public ItemsViewModel() 
        {
            Items = new ObservableCollection<Items>
           {
               new Items
               {
                   ItemImage =  "caesar.jpeg",
                   ItemName = "Caesar Pop Cigarettes",
                   ItemDescription = "Carton of 10 Packets",
                   ItemPrice = "R200",
                   ItemQuantity = "20"
               },

               new Items
               {
                   ItemImage =  "airpop.jpeg",
                   ItemName = "Airpop Orange",
                   ItemDescription = "Disposable smoking device",
                   ItemPrice = "R100",
                   ItemQuantity = "100"
               },

               new Items
               {
                   ItemImage =  "strawberryairpop.jpeg",
                   ItemName = "Strawberry Airpop",
                   ItemDescription = "Disposable smoking device",
                   ItemPrice = "R100",
                   ItemQuantity = "100"
               },

               new Items
               {
                   ItemImage =  "daybreakerbread.jpeg",
                   ItemName = "Daybreaker Bread",
                   ItemDescription = "20 Large Slice White Bread",
                   ItemPrice = "R10",
                   ItemQuantity = "20"
               },

               new Items
               {
                   ItemImage =  "saskowhitebread.jpeg",
                   ItemName = "Sasko Sam White Bread",
                   ItemDescription = "20 Large Slice Premium White Bread",
                   ItemPrice = "R18",
                   ItemQuantity = "20"
               },

               new Items
               {
                   ItemImage =  "flour.jpeg",
                   ItemName = "Sasko Sam White Flour",
                   ItemDescription = "2.5kg White Flour",
                   ItemPrice = "R90",
                   ItemQuantity = "30"
               },

               new Items
               {
                   ItemImage =  "hulletsugar.jpeg",
                   ItemName = "Huletts White Sugar",
                   ItemDescription = "2.5kg White Sugar",
                   ItemPrice = "R70",
                   ItemQuantity = "20"
               },
                
                new Items
               {
                   ItemImage =  "hulletsugar.jpeg",
                   ItemName = "Huletts White Sugar",
                   ItemDescription = "250g White Sugar",
                   ItemPrice = "R20",
                   ItemQuantity = "20"
               },

               new Items
               {
                   ItemImage =  "milk.jpeg",
                   ItemName = "Alfalfa Milk",
                   ItemDescription = "1 Litre Sachet",
                   ItemPrice = "R12",
                   ItemQuantity = "20"
               },

               new Items
               {
                   ItemImage =  "yogisip.jpeg",
                   ItemName = "Alfalfa Drinkable Yoghurt",
                   ItemDescription = "500ml Drinkable Yoghurt",
                   ItemPrice = "R10",
                   ItemQuantity = "20"
               },

               new Items
               {
                   ItemImage =  "gosloschilli.jpeg",
                   ItemName = "Goslos Chilli",
                   ItemDescription = "Chips",
                   ItemPrice = "R5",
                   ItemQuantity = "100"
               },

               new Items
               {
                   ItemImage =  "goslosperiperi.jpeg",
                   ItemName = "Goslos Peri Peri",
                   ItemDescription = "Chips",
                   ItemPrice = "R5",
                   ItemQuantity = "100"
               }

           };    
        }

    }
}
