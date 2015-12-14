using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift3();
            //Uppgift1();
            MyDoubleType mdt1 = new MyDoubleType(5);
            MyDoubleType mdt2 = mdt1 + 5;
            MyDoubleType mdt3 = mdt1 + mdt2;
            MyDoubleType mdt4 = new MyDoubleType(5);  // Kolla koden
            Console.WriteLine(mdt1);
            Console.WriteLine(mdt2);
            Console.WriteLine(mdt3);
            Console.WriteLine(mdt4);
            Console.ReadLine();

        }

        private static void Uppgift1()
        {
            float myFloat = 10.5f;
            long myLong = 12589562132546;
            char myChar = 'j';
            string myString = "JimmyBoy";
            // ulong kan inte ha negativa värden, endast positiva. Jätte långt 
            ulong SuperLångtTal = 12365478965232654589;
            Console.WriteLine(myFloat);
            Console.WriteLine(myLong);
            Console.WriteLine(myChar);
            Console.WriteLine(myString);
            Console.WriteLine(SuperLångtTal);
        }

        private static void Uppgift3()
        {
            Point point = new Point(10, 20);
            Point3D point3D = new Point3D(100, 200, 300);
            Point3D point2 = (Point3D) point;
            Point point3 = (Point) point3D;
            Console.WriteLine(point);
            Console.WriteLine(point2);
            Console.WriteLine(point3);
            Console.ReadLine();
        }
    }
}
