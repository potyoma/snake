using System.Collections.Generic;

namespace Snake
{
    public class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            PList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PList.Add(p);
            }
        }
    }
}