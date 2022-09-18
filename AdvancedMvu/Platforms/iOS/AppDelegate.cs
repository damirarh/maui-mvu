using Foundation;
using Microsoft.Maui.Hosting;

namespace AdvancedMvu;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
}

