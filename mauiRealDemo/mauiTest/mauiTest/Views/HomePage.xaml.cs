namespace mauiTest.Views;
using mauiTest.ViewModel;
public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
}
