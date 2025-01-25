using Healthy_Puppy.Data;

namespace Healthy_Puppy;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    private async void OnIniciarSesionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void OnRegistrarseClicked(object sender, EventArgs e)
    {
        var registrationPage = new RegistrationPage(App.Current.Handler.MauiContext.Services.GetService<AppDatabase>());
        await Navigation.PushAsync(registrationPage);
    }
}
