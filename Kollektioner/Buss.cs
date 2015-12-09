using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Buss
    {
        public int Seats { get; set; }
        public int HorsePowers { get; set; }

        public Buss(int seats, int horsePowers)
        {
            Seats = seats;
            HorsePowers = horsePowers;
        }

        public override string ToString() => $"Number of seats: {Seats}\nHorsePowers: {HorsePowers}";

    }
}
