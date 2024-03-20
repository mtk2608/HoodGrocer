using HoodGrocer.Models;

namespace HoodGrocer.UI;

public partial class DetailsPage : ContentPage
{
    private readonly ProductViewModel _viewModel;
    private readonly CartProductViewModel _cartViewModel;

    public DetailsPage(CartViewModel cartViewModel)
	{
		InitializeComponent();
		BindingContext = item;
        _viewModel = (ProductViewModel)BindingContext;
        _cartViewModel = cartViewModel;
    }



    //private void Add_Clicked(object sender, EventArgs e)


}