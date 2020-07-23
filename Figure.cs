using System.Collections.Generic;

namespace Snake
{
    public class Figure
    {
        protected List<Point> PList;

        public void Draw()
        {
            if (PList != null)
            {    
                foreach (Point p in PList)
                {
                    p.Draw();
                }
            }
        }
    }
}