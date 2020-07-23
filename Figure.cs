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

        internal bool IsHit(Figure figure)
        {
            foreach (var p in PList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in PList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}