using HoodGrocer.Models;

namespace HoodGrocer.UI;

public partial class DetailsPage : ContentPage
{
<<<<<<< Updated upstream


    public DetailsPage(ProductViewModel item)
	{
		InitializeComponent();
		BindingContext = item;

=======
    public DetailsPage(Product item)
	{
		InitializeComponent();
		BindingContext = item;
>>>>>>> Stashed changes
    }



    //private void Add_Clicked(object sender, EventArgs e)


}