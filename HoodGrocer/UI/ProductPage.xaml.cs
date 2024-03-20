using HoodGrocer.Models;
using HoodGrocer.Services;
using System.Collections.ObjectModel;

namespace HoodGrocer.UI;

public partial class ProductPage : ContentPage
{
    private HoodGrocerLocalDatabase _database;

    private ObservableCollection<Product> products;
    public ObservableCollection<Product> Products
    {
        get { return products; }
        set { 
            products = value; 
            OnPropertyChanged();
        }
    }


    public ProductPage()
    {
        InitializeComponent();
        _database= new HoodGrocerLocalDatabase();
        BindingContext = this;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }
    public void LoadData()
    {
        //ShoppingItems items = _database.GetItemByID(1);
        //CurrentItem = items;
        Products = new ObservableCollection<Product>(_database.GetAllItems());
    }
}