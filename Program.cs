using System;
using System.Collections.Generic;
using static System.Console;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(5, 3, '*');
            var p2 = new Point(8, 2, '/');

            p1.Draw();
            p2.Draw();

            List<Line> lines = new List<Line>()
            {
                new Line(1, 1, 20, '*'),
                new Line(1, 1, 10, '*', false),
                new Line(1, 11, 20, '*'),
                new Line(21, 1, 10, '*', false)
            };            

            foreach (Line line in lines)
            {
                line.Draw();
            }

            Read();
        }
    }
}