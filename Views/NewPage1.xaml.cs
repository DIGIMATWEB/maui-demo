namespace EcommerceMAUI.Views;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
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
