using Healthy_Puppy.Data;

namespace Healthy_Puppy;

public partial class RegistrationPage : ContentPage
{
    private readonly AppDatabase _database;

    // Constructor
    public RegistrationPage()
    {
        InitializeComponent();

        // Inicialización de _database con manejo de servicios nulos
        var mauiContext = App.Current?.Handler?.MauiContext;
        if (mauiContext == null)
        {
            throw new InvalidOperationException("No se pudo obtener el contexto de Maui.");
        }

        _database = mauiContext.Services.GetService<AppDatabase>()
                    ?? throw new InvalidOperationException("No se pudo obtener el servicio de AppDatabase.");
    }

    public async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Validación de campos vacíos
        if (string.IsNullOrWhiteSpace(OwnerNameEntry.Text) ||
            string.IsNullOrWhiteSpace(OwnerEmailEntry.Text) ||
            string.IsNullOrWhiteSpace(OwnerPhoneEntry.Text) ||
            string.IsNullOrWhiteSpace(DogNameEntry.Text) ||
            BreedPicker.SelectedItem == null ||
            (!MaleRadioButton.IsChecked && !FemaleRadioButton.IsChecked))
        {
            await DisplayAlert("Error", "Por favor completa todos los campos.", "OK");
            return;
        }

        // Crear objeto Owner
        var owner = new Models.Owner
        {
            Name = OwnerNameEntry.Text,
            Email = OwnerEmailEntry.Text,
            Phone = OwnerPhoneEntry.Text
        };

        // Guardar dueño en la base de datos
        await _database.SaveOwnerAsync(owner);

        // Mostrar éxito
        await DisplayAlert("Éxito", "Registro completado con éxito.", "OK");
    }
}
