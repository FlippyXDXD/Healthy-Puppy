using Healthy_Puppy.Data;
using System.IO;

namespace Healthy_Puppy;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.Services.AddSingleton<AppDatabase>(s =>
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "HealthyPuppy.db");
            var appDatabase = new AppDatabase(dbPath);

            Task.Run(async () => await appDatabase.InitializeDatabaseAsync()).ConfigureAwait(false);

            return appDatabase;
        });

        builder
          .UseMauiApp<App>()
          .ConfigureFonts(fonts =>
          {
              fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          });

        return builder.Build();
    }
}
