namespace MAUI_Snake;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
		var vm = new MainWindowViewModel();
		MainPage.BindingContext = vm;
	}
}
