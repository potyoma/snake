using System.Collections.Generic;
using System;

namespace Snake
{
    public class Snake : Figure
    {
        public Direction MoveDirection;

        public Snake(Point tail, int length, Direction direction)
        {
            MoveDirection = direction;
            PList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = PList[0];
            PList.Remove(tail);
            Point head = GetNextPoint();
            PList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = PList[PList.Count - 1];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, MoveDirection);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                MoveDirection = Direction.Left;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                MoveDirection = Direction.Right;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                MoveDirection = Direction.Up;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                MoveDirection = Direction.Down;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Symbol = head.Symbol;
                PList.Add(food);
                return true;
            }
            return false;
        }

        public bool IsHitTail()
        {
            Point head = GetNextPoint();
            return head.IsHit(PList[0]);
        }
    }
}