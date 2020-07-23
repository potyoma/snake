using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> PList = new List<Point>();

        public void Draw()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }
    }
}