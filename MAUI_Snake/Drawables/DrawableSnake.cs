using Snake.Core.ViewModels;

namespace MAUI_Snake
{
    public class DrawableSnake: IDrawable
    {
        public List<CellViewModel> Snake { get; set; }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.FillColor = Color.FromRgb(0, 255, 0);

            if (Snake != null && Snake.Count != 0)
            {
                foreach (var part in Snake)
                {
                    canvas.FillColor = Color.FromRgb(part.Rgb[0], part.Rgb[1], part.Rgb[2]);
                    canvas.FillEllipse(part.XPos, part.YPos, 10, 10);
                }
            }
        }
    }
}
