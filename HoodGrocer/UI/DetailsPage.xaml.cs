using HoodGrocer.Models;
using HoodGrocer.Services;

namespace HoodGrocer.UI;

[QueryProperty(nameof(Product), "CurrentProduct")]
public partial class DetailsPage : ContentPage
{
    private HoodGrocerLocalDatabase _dbConnection;

    private Product currentProduct;
    public Product CurrentProduct
    {
        get { return currentProduct; }
        set
        {
            currentProduct = value;

            OnPropertyChanged();
        }
    }

    public DetailsPage()
	{
		InitializeComponent();
 
        BindingContext = this;
    }




    //private void Add_Clicked(object sender, EventArgs e)


}