using System;

namespace Snake
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }

        public Point()
        {
        }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Symbol = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Symbol = p.Symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                X += offset;
            }
            else if (direction == Direction.Left)
            {
                X -= offset;
            }
            else if (direction == Direction.Up)
            {
                Y -= offset;
            }
            else
            {
                Y += offset;
            }
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return p.X == this.X && p.Y == this.Y;
        }
    }
}