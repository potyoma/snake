using System.Collections.Generic;

namespace Snake
{
    public class Figure : Point
    {
        protected List<Point> PList;

        public override void Draw()
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