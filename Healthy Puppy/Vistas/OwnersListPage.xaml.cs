using Healthy_Puppy.Data;

namespace Healthy_Puppy;

public partial class OwnersListPage : ContentPage
{
    private readonly AppDatabase _database;

    // Constructor
    public OwnersListPage()
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

        LoadOwners();
    }

    private async void LoadOwners()
    {
        try
        {
            // Obtener la lista de dueños desde la base de datos
            var owners = await _database.GetOwnersAsync();

            // Enlazar la lista de dueños con la vista
            OwnersCollectionView.ItemsSource = owners;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo cargar la lista de dueños: {ex.Message}", "OK");
        }
    }
}
