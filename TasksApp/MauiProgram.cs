using Microsoft.Extensions.Logging;
using TasksApp.ViewModel;

namespace TasksApp
{
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
			// registering the service we added
			// global stati is created once
			// transient is created each time
			// this is dependency injection
			builder.Services.AddSingleton<MainPage>();
			builder.Services.AddSingleton<MainViewModel>();

			// more dependency injection
			// transient is created and destroyed each time 
			// singleton is stored in memory, like global
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();

            return builder.Build();
		}
	}
}
