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

            GamerInput(snake);
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

        static void GamerInput(Snake snake)
        {
            while (true)
            {
                if (KeyAvailable)
                {
                    ConsoleKeyInfo key = ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        snake.MoveDirection = Direction.Left;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        snake.MoveDirection = Direction.Right;
                    }
                    else if (key.Key == ConsoleKey.UpArrow)
                    {
                        snake.MoveDirection = Direction.Up;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        snake.MoveDirection = Direction.Down;
                    }
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}