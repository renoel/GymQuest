using GymQuest.ApiClients;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace GymQuest;
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
            });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();
        builder.Services.AddScoped<RoutineApiClient>();
        builder.Services.AddScoped<AchievementApiClient>();

#if ANDROID
        var apiBaseUrl = "http://10.0.2.2:5230/";
#else
        var apiBaseUrl = "http://localhost:5230/";
#endif

        builder.Services.AddScoped(sp => new HttpClient
        {
            BaseAddress = new Uri(apiBaseUrl)
        });

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}