using mauiTest.Views;
namespace mauiTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();//AppShell();//MainPage();
		//hola mundo 
    }
}

