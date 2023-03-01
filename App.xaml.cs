using EcommerceMAUI.Views;

namespace EcommerceMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NewPage1();//AppShell();
        //MainPage = new AppShell();
    }
}
