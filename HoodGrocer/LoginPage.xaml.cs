using HoodGrocer.Services;
using HoodGrocer.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;

namespace HoodGrocer;

public partial class LoginPage : ContentPage
{
    private HoodGrocerLocalDatabase _dbConnection;

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


    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }

    private void LoadData()
    {
        Client client = _dbConnection.GetClientById(1);

        CurrentClient = client;

    }


    public LoginPage()
	{
		InitializeComponent();
        _dbConnection = new HoodGrocerLocalDatabase();
        BindingContext = this;
    }


    private void Save_Clicked(object sender, EventArgs e)
    {
        _dbConnection.UpdateClient(CurrentClient);
    }

    private void Load_Clicked(object sender, EventArgs e)
    {
        LoadData();
    }
}