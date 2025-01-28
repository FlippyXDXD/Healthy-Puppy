namespace Healthy_Puppy;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnInfoPerroClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/InfoPerroPage");
    }
    private async void OnMedicalControlClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ControlMedicoPage");
    }

    private async void OnDiagnosticoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DiagnosticoPage");
    }

    private async void OnCalendarioClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CalendarioPage");
    }

    private async void OnConfiguracionClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ConfiguracionPage");
    }
}