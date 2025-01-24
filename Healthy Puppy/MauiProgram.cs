using Healthy_Puppy.Data;
using System.IO;

namespace Healthy_Puppy;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        // Ruta para la base de datos
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "healthy_puppy.db");

        // Registrar la base de datos como un servicio
        builder.Services.AddSingleton<AppDatabase>(s => new AppDatabase(dbPath));

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}
