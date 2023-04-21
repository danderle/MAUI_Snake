using Snake.Core.ViewModels;

namespace MAUI_Snake;

public partial class MainPage : ContentPage
{
	private CancellationTokenSource cancellation = new CancellationTokenSource();
	public MainPage()
	{
		InitializeComponent();
		var vm = new MainWindowViewModel();
		BindingContext = vm;
		vm.FruitChangedAction = FruitChanged;
		vm.SnakeChangedAction = SnakeChanged;
		vm.GameOverAction = GameOverChanged;
    }

    private void GameOverChanged()
    {
		cancellation.Cancel();
    }

    private void SnakeChanged(List<CellViewModel> cells)
    {
        drawableSnake.Snake = cells;
        snakeGraphicsView.Invalidate();
    }

    private void FruitChanged(CellViewModel cell)
	{
		drawableFruit.Fruit = cell;
		cancellation.Cancel();

		StartFruitAnimation();
	}

	private async void StartFruitAnimation()
	{
		cancellation = new CancellationTokenSource();
		await Task.Factory.StartNew(() =>
		{
			while (!cancellation.IsCancellationRequested)
			{
				fruitGraphicsView.Invalidate();
				Task.Delay(50, cancellation.Token);
			}
		});
	}
}

