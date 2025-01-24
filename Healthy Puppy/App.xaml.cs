namespace Healthy_Puppy;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Define la ventana inicial de la aplicación
        return new Window(new NavigationPage(new SplashPage()));
    }
}