namespace Healthy_Puppy;

public partial class InfoPerroPage : ContentPage
{
    public InfoPerroPage()
    {
        InitializeComponent();
        // Configurar el bot�n para regresar
        NavigateBackCommand = new Command(() =>
        {
            // Regresa a la p�gina anterior
            if (Window != null && Window.Page is NavigationPage navigationPage)
            {
                navigationPage.PopAsync();
            }
            else
            {
                Console.WriteLine("No se pudo realizar la navegaci�n: La ventana o la p�gina son nulas.");
            }
        });
        BindingContext = this;
    }

    public Command NavigateBackCommand { get; }
}
