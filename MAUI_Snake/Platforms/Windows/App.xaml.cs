using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MAUI_Snake.WinUI;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : MauiWinUIApplication
{
	const int WindowWidth = 800;
	const int WindowHeight = 800;

    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
	{
		this.InitializeComponent();

		Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
		{
			var mauiWindow = handler.VirtualView;
			var nativeWindow = handler.PlatformView;
			nativeWindow.Activate();
			IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
			WindowId windowId = Win32Interop.GetWindowIdFromWindow(windowHandle);
			AppWindow appWindow = AppWindow.GetFromWindowId(windowId);

			appWindow.Resize(new Windows.Graphics.SizeInt32(WindowWidth, WindowHeight));
		});

	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

