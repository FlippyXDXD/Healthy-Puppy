namespace Healthy_Puppy;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Navegar a la página de información del perro
    private async void OnViewOwnersClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//OwnersListPage");
    }

    // Navegar a la página de control médico
    private async void OnMedicalControlClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ControlMedicoPage");
    }

    // Navegar a la página de diagnóstico
    private async void OnDiagnosisClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DiagnosticoPage");
    }

    // Navegar a la página de calendario
    private async void OnCalendarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//CalendarioPage");
    }

    // Navegar a la página de configuraciones
    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ConfiguracionPage");
    }
}
