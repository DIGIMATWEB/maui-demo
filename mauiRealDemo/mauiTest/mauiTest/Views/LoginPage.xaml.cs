namespace mauiTest.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

    }
        private void Login_Clicked(object sender, EventArgs e)
        {
            //await App.Current.MainPage.DisplayToastAsync("This is a toast message!");
            // Navigation.PushAsync(new AppShell());
            //await Navigation.PushModalAsync(new AppShell());
            Application.Current.MainPage.Navigation.PushModalAsync(new AppShell());
        }

        private async void CreateAccount_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CreateAccountPage());
        }
    }
    
