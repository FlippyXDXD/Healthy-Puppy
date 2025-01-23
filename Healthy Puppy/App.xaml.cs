using Microsoft.Maui.Controls;

namespace Healthy_Puppy;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Configuración inicial: Pantalla de carga
        MainPage = new SplashPage();
    }
}
