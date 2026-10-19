using Microsoft.Extensions.Logging;
using Bilvaerksted.Services;
using Bilvaerksted.ViewModels;
using Bilvaerksted.Views;

namespace Bilvaerksted;

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

		builder.Services.AddSingleton<DatabaseService>();
		builder.Services.AddTransient<BookOpgaveViewModel>();
		builder.Services.AddTransient<BookOpgavePage>();
		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<KalenderViewModel>();
		builder.Services.AddTransient<KalenderPage>();
		builder.Services.AddTransient<LavFakturaViewModel>();
		builder.Services.AddTransient<LavFakturaPage>();
		builder.Services.AddTransient<SeFakturaerViewModel>();
		builder.Services.AddTransient<SeFakturaerPage>();

		return builder.Build();
	}
}
