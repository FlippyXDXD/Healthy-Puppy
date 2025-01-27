namespace Healthy_Puppy;

public partial class InfoPerroPage : ContentPage
{
    public InfoPerroPage()
    {
        InitializeComponent();
        // Configurar el botón para regresar
        NavigateBackCommand = new Command(() =>
        {
            // Regresa a la página anterior
            if (Window != null && Window.Page is NavigationPage navigationPage)
            {
                navigationPage.PopAsync();
            }
            else
            {
                Console.WriteLine("No se pudo realizar la navegación: La ventana o la página son nulas.");
            }
        });
        BindingContext = this;
    }

    public Command NavigateBackCommand { get; }
}
