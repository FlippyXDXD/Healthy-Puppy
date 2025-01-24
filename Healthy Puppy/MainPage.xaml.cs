namespace Healthy_Puppy;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Navegar a la página de registro
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//RegistrationPage");
    }

    // Navegar a la página de lista de dueños
    private async void OnViewOwnersClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//OwnersListPage");
    }

    // Navegar a la página de control médico (en blanco por ahora)
    private async void OnMedicalControlClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ControlMedicoPage");
    }

    // Navegar a la página de diagnóstico (en blanco por ahora)
    private async void OnDiagnosisClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DiagnosticoPage");
    }

    // Navegar a la página de configuraciones (en blanco por ahora)
    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SettingsPage");
    }
}
