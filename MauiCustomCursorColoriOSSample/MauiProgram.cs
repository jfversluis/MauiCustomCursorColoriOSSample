using Microsoft.Extensions.Logging;

namespace MauiCustomCursorColoriOSSample;

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

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CursorColor", (handler, view) =>
        {
#if IOS
			handler.PlatformView.TintColor = UIKit.UIColor.Green;
#endif
        });

        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("CursorColor", (handler, view) =>
        {
#if IOS
            handler.PlatformView.TintColor = UIKit.UIColor.Green;
#endif
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

