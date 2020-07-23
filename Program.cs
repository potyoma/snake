using System;
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

            Read();
        }
    }
}