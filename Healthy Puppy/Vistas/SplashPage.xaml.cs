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
        var mainWindow = Application.Current?.Windows.FirstOrDefault();
        if (mainWindow != null)
        {
            mainWindow.Page = new NavigationPage(new InicioPage());
        }
    }
}
