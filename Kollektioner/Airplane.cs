using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Airplane : IComparable<Airplane>
    {
        public int Seats { get; set; }
        public int Pilots { get; set; }

        public Airplane(int seats, int pilots)
        {
            Seats = seats;
            Pilots = pilots;
        }

        public override string ToString() => $"Number of seats: {Seats}\nPilots: {Pilots}";
        public int CompareTo(Airplane obj)
        {
            //Airplane testPlane = (Airplane) obj;
            // returnera -1, 0 eller 1
            //return testPlane.Seats.CompareTo(this.Seats);
            return obj.Pilots.CompareTo(this.Pilots);
        }
    }
}
