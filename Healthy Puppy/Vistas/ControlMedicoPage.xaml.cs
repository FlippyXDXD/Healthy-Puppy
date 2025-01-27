namespace Healthy_Puppy;

public partial class ControlMedicoPage : ContentPage
{
    public ControlMedicoPage()
    {
        InitializeComponent();
        NavigateBackCommand = new Command(() =>
        {
            if (Window?.Page is NavigationPage navigationPage)
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
