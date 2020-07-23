using System;
using System.Collections.Generic;
using static System.Console;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawFrame();
            DrawSnake(new Point(6, 4, '*'));
            Read();
        }

        static void DrawFrame()
        {
            List<Line> lines = new List<Line>()
            {
                new Line(1, 1, 20, '+'),
                new Line(1, 1, 10, '+', false),
                new Line(1, 11, 20, '+'),
                new Line(21, 1, 10, '+', false)
            };            

            foreach (Line line in lines)
            {
                line.Draw();
            }
        }

        static void DrawSnake(Point point)
        {
            Snake snake = new Snake(point, 5, Direction.Down);
            snake.Draw();
        }
    }
}