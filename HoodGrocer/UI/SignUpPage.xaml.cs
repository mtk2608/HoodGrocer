using HoodGrocer.Services;
using HoodGrocer.Models;

namespace HoodGrocer.UI;

public partial class SignUpPage : ContentPage
{
    public HoodGrocerLocalDatabase _database;

    public Client currentClient;
    public Client CurrentClient
    {
        get { return currentClient; }
        set
        {
            currentClient = value;

            OnPropertyChanged();
        }
    }

    public SignUpPage()
	{
		InitializeComponent();
        _database = new HoodGrocerLocalDatabase();
        BindingContext = this;
    }

    private void Save_Clicked(object sender, EventArgs e)
    {
        _database.UpdateClient(CurrentClient);
    }

}