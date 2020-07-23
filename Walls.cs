using System.Collections.Generic;

namespace Snake
{
    public class Walls
    {
        List<Figure> WallList;

        public Walls(int mapWidth, int mapHeight)
        {
            WallList = new List<Figure>() 
            {
                new Line(1, 1, 77, '+'),
                new Line(1, 1, 23, '+', false),
                new Line(1, 24, 77, '+'),
                new Line(78, 1, 23, '+', false)
            };    
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in WallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in WallList)
            {
                wall.Draw();
            }
        }
    }
}