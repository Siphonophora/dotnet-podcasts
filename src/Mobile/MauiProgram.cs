﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using MonkeyCache.FileStore;

namespace Microsoft.NetConf2021.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder

            .UseMauiApp<App>()
            .ConfigureEssentials()
            .ConfigureServices()
            .ConfigureViewModels()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Segoe-Ui-Bold.ttf", "SegoeUiBold");
                fonts.AddFont("Segoe-Ui-Regular.ttf", "SegoeUiRegular");
                fonts.AddFont("Segoe-Ui-Semibold.ttf", "SegoeUiSemibold");
                fonts.AddFont("Segoe-Ui-Semilight.ttf", "SegoeUiSemilight");
            });

        builder.Services.AddMauiBlazorWebView();

        Barrel.ApplicationId = "dotnetpodcasts";

        return builder.Build();
    }
}
