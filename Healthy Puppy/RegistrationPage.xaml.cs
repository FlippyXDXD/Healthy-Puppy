namespace Healthy_Puppy;

public partial class RegistrationPage : ContentPage
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Obtener los valores ingresados por el usuario
        string ownerName = OwnerNameEntry.Text;
        string ownerEmail = OwnerEmailEntry.Text;
        string ownerPhone = OwnerPhoneEntry.Text;

        // Validar que los campos no estén vacíos
        if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(ownerEmail) || string.IsNullOrWhiteSpace(ownerPhone))
        {
            await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
            return;
        }

        try
        {
            // Guardar los datos en la base de datos
            var owner = new Owner
            {
                Name = ownerName,
                Email = ownerEmail,
                Phone = ownerPhone
            };

            await App.Database.SaveOwnerAsync(owner);

            // Confirmación al usuario
            await DisplayAlert("Éxito", "Datos registrados correctamente.", "OK");

            // Opcional: Navegar a la pantalla principal
            await Shell.Current.GoToAsync("//MainPage");
        }
        catch (Exception ex)
        {
            // Manejo de errores
            await DisplayAlert("Error", $"Ocurrió un error al guardar los datos: {ex.Message}", "OK");
        }
    }
}
