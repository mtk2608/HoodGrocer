using HoodGrocer.Models;

namespace HoodGrocer.UI;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(ProductViewModel item)
	{
		InitializeComponent();
		BindingContext = item;
	}
}