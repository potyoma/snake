using System;

namespace Snake
{
    public class FoodCreator
    {
        int MapWidth;
        int MapHeight;
        char Symbol = '$';

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeight;
        }

        public Point CreateFood()
        {
            int x = random.Next(3, MapWidth - 3);
            int y = random.Next(3, MapHeight - 3);
            return new Point(x, y, Symbol);
        }
    }
}