using Snake.Core.ViewModels;

namespace MAUI_Snake;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		var vm = new MainWindowViewModel();
		BindingContext = vm;
		vm.FruitChangedAction = FruitChanged;
		vm.SnakeChangedAction = SnakeChanged;
	}


    private void SnakeChanged(List<CellViewModel> cells)
    {
        drawableSnake.Snake = cells;
        snakeGraphicsView.Invalidate();
    }

    private void FruitChanged(CellViewModel cell)
	{
		drawableFruit.Fruit = cell;
		fruitGraphicsView.Invalidate();
	}
}

