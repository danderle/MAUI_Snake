using Snake.Core.ViewModels;

namespace MAUI_Snake;
public class DrawableFruit : IDrawable
{
    private int _currentR = 0;
    private const int _rChanger = 10;
    private int _direction = 1;

    public CellViewModel Fruit { get; set; }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        if (Fruit == null)
        {
            return;
        }

        _currentR += (_rChanger * _direction);
        if (_currentR > 255)
        {
            _currentR = 255;
            _direction = -1;
        }
        else if(_currentR < 0)
        {
            _currentR = 0;
            _direction = 1;
        }

        canvas.FillColor = Color.FromRgb(_currentR, 0, 0);
        canvas.FillEllipse(Fruit.XPos, Fruit.YPos, 10, 10);
    }
}
