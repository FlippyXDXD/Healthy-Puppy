using Microsoft.Maui.Controls;

namespace Healthy_Puppy;

public partial class CalendarioPage : ContentPage
{
    public CalendarioPage()
    {
        InitializeComponent();
    }

    // Navega hacia la página anterior
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    // Navega hacia la página de inicio
    private async void OnHomeButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    // Navega hacia la página siguiente(Pendiente)
}