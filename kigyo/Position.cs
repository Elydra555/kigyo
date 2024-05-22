using System;

namespace kigyo
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Position(Position p)
        {
            X = p.X;
            Y = p.Y;
        }
        public Position()
        {
            Random rnd = new Random();
            X = rnd.Next(20);
            Y = rnd.Next(20);
        }
    }
}
