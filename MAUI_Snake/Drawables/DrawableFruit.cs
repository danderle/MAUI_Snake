using Snake.Core.ViewModels;

namespace MAUI_Snake
{
    public class DrawableFruit : IDrawable
    {
        public CellViewModel Fruit { get; set; }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.FillColor = Color.FromRgb(255, 0, 0);

            if (Fruit != null)
            {
                canvas.FillEllipse(Fruit.XPos, Fruit.YPos, 10, 10);
            }
        }
    }
}
