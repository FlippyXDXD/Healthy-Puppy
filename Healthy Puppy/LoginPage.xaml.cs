namespace Healthy_Puppy;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Por favor complete todos los campos", "OK");
            return;
        }

        // Aqu� validamos las credenciales
        await DisplayAlert("�xito", "Inicio de sesi�n exitoso", "OK");
        await Navigation.PushAsync(new MainPage()); // Navegar a la pantalla principal
    }
}
