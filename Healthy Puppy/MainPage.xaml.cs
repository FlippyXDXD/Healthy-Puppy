namespace Healthy_Puppy;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnDiagnosticoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DiagnosticoPage());
    }

    private async void OnCalendarioClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CalendarioPage());
    }

    private async void OnControlMedicoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ControlMedicoPage());
    }

    private async void OnInfoPerroClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InfoPerroPage());
    }

    private async void OnConfigClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConfiguracionPage());
    }
}
