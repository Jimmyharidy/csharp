using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //CelsiusCastings();
            Point point = new Point(50,50);
            Point3D point3D = new Point3D(50,50,25);
            
            Console.ReadLine();
        }

        private static void CelsiusCastings()
        {
            Fahrenheit fahrenheit = new Fahrenheit(100.0f);
            Console.WriteLine($"Fahrenheit: { fahrenheit.Temp}");
            Celsius celsius = (Celsius)fahrenheit;
            Console.WriteLine($"Celsius: {celsius.Temp}");
            Fahrenheit fahrenheit2 = (Fahrenheit)celsius;
            Console.WriteLine($"Fahrenheit2: { celsius.Temp}");
            Console.ReadLine();
        }
    }
}
