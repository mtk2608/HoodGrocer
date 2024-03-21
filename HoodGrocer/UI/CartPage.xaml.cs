using HoodGrocer.Models;
using HoodGrocer.Services;
using System.Collections.ObjectModel;

namespace HoodGrocer.UI;

public partial class CartPage : ContentPage
{
    private HoodGrocerLocalDatabase _database;

    private ObservableCollection<CartProduct> _cartProducts;
    public ObservableCollection<CartProduct> CartProducts
    {
        get { return _cartProducts; }
        set
        { _cartProducts = value;
            OnPropertyChanged();
        }
    }
    public CartPage()
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
        CartProducts = new ObservableCollection<CartProduct>(_database.GetAllCartItems());
    }

    private void OnRemoveClicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        var cartProduct = button.CommandParameter as CartProduct;
        if (cartProduct != null)//(sender is Button button && button.BindingContext is CartItem item)
        {
            CartProducts.Remove(cartProduct);
            _database.GetAllCartItems().Remove(cartProduct); //Check this
        }
    }
}