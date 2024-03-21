using HoodGrocer.Models;
using HoodGrocer.Services;
using System.Collections.ObjectModel;

namespace HoodGrocer.UI;

public partial class ProductPage : ContentPage
{
    private HoodGrocerLocalDatabase _database;

    private ObservableCollection<Product> _items;
    public ObservableCollection<Product> Items
    {
        get { return _items; }
        set
        {
            _items = value;
            OnPropertyChanged();
        }
    }
    public ProductPage()
    {
        InitializeComponent();
        _database = new HoodGrocerLocalDatabase();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }
    public void LoadData()
    {
        Items = new ObservableCollection<Product>(_database.GetAllItems());
    }

    private List<CartProduct> CartItems = new List<CartProduct>();
    private async void Cart_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        var selected = button.CommandParameter as Product;

        if (selected != null)
        {
            CartProduct existing = CartItems.FirstOrDefault(i => i.ItemsId == selected.ItemsId);
            if (existing != null)
            {
                existing.Quantity++;
                existing.CartTotal += selected.ItemPrice;
            }
            else
            {
                CartProduct cartProduct = new CartProduct()
                {
                    CartName = selected.ItemName,
                    Quantity = 1,
                    CartTotal = selected.ItemPrice,
                    CartImage = selected.ItemImage,
                    CartId = selected.ItemsId
                };
                CartItems.Add(cartProduct);
                _database.InsertToDatabase(cartProduct);
                await DisplayAlert("Saved", "Item Added To Cart", "Amazing");
            }
        } //Items add to cart and saved to database does not display in UI 
    }

}