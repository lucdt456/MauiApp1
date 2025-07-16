using MauiApp1.Features.Login.Services;
using MauiApp1.Features.Login.Viewmodels;
using MauiApp1.Features.Login.Views;
using Microsoft.Extensions.Logging;

namespace MauiApp1
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
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddSingleton<App>();

            builder.Services.AddScoped<IAuthService, AuthService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            var app = builder.Build();
            return app;
        }
    }
}
