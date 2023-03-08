using mauiTest.ViewModel;
namespace mauiTest.Views;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
        BindingContext = new ProfileViewModel();
    }
}
