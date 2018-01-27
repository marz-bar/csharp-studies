﻿namespace Exercises
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

        public void Move (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move (Point newDirection)
        {
            this.X = newDirection.X;
            this.Y = newDirection.Y;
        }
        
    }
}

