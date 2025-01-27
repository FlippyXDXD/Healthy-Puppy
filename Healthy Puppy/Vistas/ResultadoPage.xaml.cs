namespace Healthy_Puppy;

public partial class ResultadoPage : ContentPage
{
    public ResultadoPage()
    {
        InitializeComponent();

        // Configura el comando para regresar a la pantalla principal
        NavigateToMainPageCommand = new Command(() =>
        {
            if (Window?.Page is NavigationPage navigationPage)
            {
                // Limpia la pila de navegación y regresa al MainPage
                navigationPage.PopToRootAsync();
            }
            else
            {
                Console.WriteLine("Error: No se pudo navegar a la pantalla principal.");
            }
        });

        BindingContext = this;
    }

    public Command NavigateToMainPageCommand { get; }
}