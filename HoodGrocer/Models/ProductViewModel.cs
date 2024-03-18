using HoodGrocer.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HoodGrocer.Models
{

    public class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ObservableCollection<Product> CartProducts { get; set; }

        public Product SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        public ICommand CartProductClick { get; set; }

        public ProductViewModel(INavigation navigation)
        {

            Products = new ObservableCollection<Product>
{
                 new Product
                 {
                    ItemImage =  "caesar.jpeg",
                    ItemName = "Caesar Pop Cigarettes",
                    ItemDescription = "Carton of 10 Packets",
                    ItemPrice = "R200",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "airpop.jpeg",
                    ItemName = "Airpop Orange",
                    ItemDescription = "Disposable smoking device",
                    ItemPrice = "R100",
                    ItemQuantity = "100"
                 },

                 new Product
                 {
                    ItemImage =  "strawberryairpop.jpeg",
                    ItemName = "Strawberry Airpop",
                    ItemDescription = "Disposable smoking device",
                    ItemPrice = "R100",
                    ItemQuantity = "100"
                 },

                 new Product
                 {
                    ItemImage =  "daybreakerbread.jpeg",
                    ItemName = "Daybreaker Bread",
                    ItemDescription = "20 Large Slice White Bread",
                    ItemPrice = "R10",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "saskowhitebread.jpeg",
                    ItemName = "Sasko Sam White Bread",
                    ItemDescription = "20 Large Slice Premium White Bread",
                    ItemPrice = "R18",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "flour.jpeg",
                    ItemName = "Sasko Sam White Flour",
                    ItemDescription = "Sasko Cake Wheat Flour is ideally suited for baking cakes, bread and other baked goods which require cake what flour. Cake wheat flour is produced by removing the wheat kernels' layer of germ and bran and grinding the leftover endosperm into flour. Cake flour is whiter in colour than white bread flour and is regarded as far superior.\r\n\r\nProduct Information:\r\nHalaal\r\nKosher\r\nSuitable for vegetarians\r\n2.5kg.",
                    ItemPrice = "R90",
                    ItemQuantity = "30"
                 },

                 new Product
                 {
                    ItemImage =  "hulletsugar.jpeg",
                    ItemName = "Huletts White Sugar",
                    ItemDescription = "2.5kg White Sugar",
                    ItemPrice = "R70",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "hulletsugar.jpeg",
                    ItemName = "Huletts White Sugar",
                    ItemDescription = "250g White Sugar",
                    ItemPrice = "R20",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "milk.jpeg",
                    ItemName = "Alfalfa Milk",
                    ItemDescription = "1 Litre Sachet",
                    ItemPrice = "R12",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "yogisip.jpeg",
                    ItemName = "Alfalfa Drinkable Yoghurt",
                    ItemDescription = "500ml Drinkable Yoghurt",
                    ItemPrice = "R10",
                    ItemQuantity = "20"
                 },

                 new Product
                 {
                    ItemImage =  "gosloschilli.jpeg",
                    ItemName = "Goslos Chilli",
                    ItemDescription = "Chips",
                    ItemPrice = "R5",
                    ItemQuantity = "100"
                 },

                 new Product
                 {
                 ItemImage =  "goslosperiperi.jpeg",
                 ItemName = "Goslos Peri Peri",
                 ItemDescription = "Chips",
                 ItemPrice = "R5",
                 ItemQuantity = "100"
                 }
            };

            CartProducts = new ObservableCollection<Product> { };

            ProductClick = new Command<Product>(executeProductClickCommand);

            CartProductClick = new Command<Product>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(Product item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            await navigation.PushModalAsync(new DetailsPage(this));
        }

        async void executeCartProductClickCommand(Product item)
        {
            this.CartProducts.Add(this.SelectedProduct);
            //await navigation.PushModalAsync(new CartPage(this));

        }
    }

}

