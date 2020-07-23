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
            
            DrawFrame();
            
            Snake snake = new Snake(new Point(5, 3, '*'), 5, Direction.Down);
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25);
            Point food = foodCreator.CreateFood();
            food.Draw();

            GamerInput(snake, ref food, foodCreator);
        }

        static void DrawFrame()
        {
            List<Line> lines = new List<Line>()
            {
                new Line(1, 1, 77, '+'),
                new Line(1, 1, 23, '+', false),
                new Line(1, 24, 77, '+'),
                new Line(78, 1, 23, '+', false)
            };            

            foreach (Line line in lines)
            {
                line.Draw();
            }
        }

        static void GamerInput(Snake snake, ref Point food, FoodCreator foodCreator)
        {
            while (true)
            {
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