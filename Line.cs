using System.Collections.Generic;

namespace Snake
{
    public class Line
    {
        List<Point> PList = new List<Point>();

        public Line(int xStart, int yStart, int length, char symbol, bool isHorisontal = true)
        {
            if (isHorisontal)
            {
                for (int i = xStart; i <= xStart + length; i++)
                {
                    PList.Add(new Point(i, yStart, symbol));
                }
            }
            else
            {
                for (int i = yStart; i <= yStart + length; i++)
                {
                    PList.Add(new Point(xStart, i, symbol));
                }
            }
        }

        public void Draw()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }
    }
}