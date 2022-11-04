﻿
using Plugin.Maui.Audio;

namespace EOKeksi;

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
                fonts.AddFont("Roboto-Black.ttf", "Roboto");
            });



        builder.Services.AddSingleton(AudioManager.Current);
		builder.Services.AddTransient<MainPage>();

        return builder.Build();
	}
}