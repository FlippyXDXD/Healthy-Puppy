namespace Healthy_Puppy;

public partial class SplashPage : ContentPage
{
    public SplashPage()
    {
        InitializeComponent();
        NavigateToInicioPage();
    }

    private async void NavigateToInicioPage()
    {
        // Esperar 3 segundos
        await Task.Delay(3000);

        // Cambiar a la pantalla de inicio
        Application.Current.MainPage = new NavigationPage(new InicioPage());
    }
}
