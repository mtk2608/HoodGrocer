using HoodGrocer.Models;
using HoodGrocer.Services;


namespace HoodGrocer.UI;

public partial class LoginPage : ContentPage
{

    private HoodGrocerLocalDatabase _database;

    private Client currentClient;
    public Client CurrentClient
    {
        get { return currentClient; }
        set
        {
            currentClient = value;

            OnPropertyChanged();
        }
    }

    public LoginPage()
	{
		InitializeComponent();

	}



}