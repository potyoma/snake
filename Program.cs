using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            SetWindowSize(80,25);
            SetBufferSize(80,25);
            
            var walls = new Walls(80, 25);
            walls.Draw();
            
            Snake snake = new Snake(new Point(5, 3, '*'), 5, Direction.Down);
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25);
            Point food = foodCreator.CreateFood();
            food.Draw();

            GamerInput(snake, ref food, foodCreator, ref walls);
        }

        static void GamerInput(Snake snake, ref Point food, FoodCreator foodCreator, ref Walls walls)
        {
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }

                if (KeyAvailable)
                {
                    ConsoleKeyInfo key = ReadKey();
                    snake.HandleKey(key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}