using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    public class Position
    {
        int x { get; set; }
        int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }        
        public Position()
        {
            Random rnd = new Random();
            x = rnd.Next(20);
            y = rnd.Next(20);
        }


    }
}
