using HoodGrocer.UI;

namespace HoodGrocer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SignUpPage();
        }
    }
}
