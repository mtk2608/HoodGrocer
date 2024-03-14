using HoodGrocer.Models;
using HoodGrocer.Services;

namespace HoodGrocer.UI;

public partial class LoginPage : ContentPage
{

	private HoodGrocerLocalDatabase _database;

	private Client currentclient;

	public Client Currentclient
	{
		get { return currentclient; }
		set { currentclient = value; }

		OnPropertyChanged();

	}

	public LoginPage()
	{
		InitializeComponent();
	}
}