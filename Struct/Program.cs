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
            //StructDemo2();
            Mixture mix1 = new Mixture(){MyBool = true, MyDouble = 5.5, Myint = 20};
            Console.WriteLine(mix1);
            Mixture mix2;
            mix2.MyBool = false;
            mix2.MyDouble = 100.3321;
            mix2.Myint = 1033;
            Console.WriteLine(mix2);
            Console.ReadLine();
        }

        private static void StructDemo2()
        {
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
