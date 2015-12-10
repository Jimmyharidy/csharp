using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructDemo1();
            Point ett;
            ett.X = 4;
            ett.Y = 5;
            ett = new Point(0);
            Console.WriteLine("X: {0}, Y: {1}", ett.X, ett.Y);
        }

        private static void StructDemo1()
        {
            Kordinat kordinat;
            kordinat.X = 66;
            kordinat.Y = 88;

            Kordinat origo = new Kordinat() { X = 50, Y = 50 };
            origo.Z = "19";
            origo = new Kordinat();  // Nollställer structen
            // alla fält får defaultvärdet från respektive datatyp
            // observera att string fick null i sig nu. 
            Console.WriteLine(origo);
            Console.ReadLine();
        }
    }
}
