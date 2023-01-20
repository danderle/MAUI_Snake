using Snake.Core.DataModels;

namespace Snake.Core.Models
{
    public class NextMove
    {
        public int Xpos { get; }
        public int Ypos { get; }
        public Direction Direction { get; }


        public NextMove(int xpos, int ypos, Direction direction)
        {
            Xpos = xpos;
            Ypos = ypos;
            Direction = direction;
        }
    }
}
