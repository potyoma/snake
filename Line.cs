using System.Collections.Generic;

namespace Snake
{
    public class Line : Figure
    {
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
    }
}