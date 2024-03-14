namespace HoodGrocer.UI;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new YourViewModel();
    }

    public class YourViewModel
    {
        public ImageSource ImageSource { get; } = ImageSource.FromFile("Images/saskowhitebread.png");
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CartPage());
    }


}