﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
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
