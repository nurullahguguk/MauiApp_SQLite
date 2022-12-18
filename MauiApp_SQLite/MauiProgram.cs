using MauiApp_SQLite.DataTransactions;
using Microsoft.Extensions.Logging;

namespace MauiApp_SQLite;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		string _DbPath = Path.Combine(FileSystem.AppDataDirectory, "Student.db");

		builder.Services.AddSingleton(s=>
		ActivatorUtilities.CreateInstance<DbTrans>(s, _DbPath));


        return builder.Build();
	}
}
