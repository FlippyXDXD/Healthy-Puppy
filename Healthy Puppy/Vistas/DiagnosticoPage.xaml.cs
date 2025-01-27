using Healthy_Puppy.Vistas;

namespace Healthy_Puppy;

public partial class DiagnosticoPage : ContentPage
{
    public DiagnosticoPage()
    {
        InitializeComponent();

        // Comando para navegar a la p�gina de resultados
        NavigateToResultadoCommand = new Command(() =>
        {
            // Navega a la p�gina Resultado
            if (Window?.Page is NavigationPage navigationPage)
            {
                navigationPage.PushAsync(new ResultadoPage());
            }
            else
            {
                Console.WriteLine("Error: No se pudo navegar a la p�gina de resultados.");
            }
        });

        // Comando para regresar
        NavigateBackCommand = new Command(() =>
        {
            if (Window?.Page is NavigationPage navigationPage)
            {
                navigationPage.PopAsync();
            }
            else
            {
                Console.WriteLine("Error: No se pudo regresar.");
            }
        });

        BindingContext = this;
    }

    public Command NavigateToResultadoCommand { get; }
    public Command NavigateBackCommand { get; }
}