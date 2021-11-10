using MauiBlazor.Data;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using RazorClassLibrary;

namespace MauiBlazor
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .RegisterBlazorMauiWebView()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddBlazorWebView();
            builder.Services.AddRazorClassLibraryUi("erver=(localdb)\\mssqllocaldb;Database=aspnet-BlazorServer-900F2E37-EE63-41B3-A9C3-FC861BA223ED;Trusted_Connection=True;MultipleActiveResultSets=true");

            return builder.Build();
        }
    }
}