using System.Collections.Generic;

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
    }
}