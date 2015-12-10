using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Point
    {
        public int X;
        public int Y;

        /*
        - Man får inte göra en tom constructor
        - om man gör en överlagrad konstruktor måste man sätta 
        ett värde på alla fält

    */

        public Point(int x)
        {
            X = 5;
            Y = 7;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int GetXy() => X + Y;
    }
}
