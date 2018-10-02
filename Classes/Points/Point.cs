using System;

namespace Points
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newPosition)
        {
            if (newPosition == null)
                throw new ArgumentNullException("newPosition can't be null");
            Move(newPosition.X, newPosition.Y);
        }

    }
}
