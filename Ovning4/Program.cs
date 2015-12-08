using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass();
            RadioClass();
            RadioClass2();
            RadioObjectInitializer();

        }

        private static void RadioObjectInitializer()
        {
            Radio radio = new Radio() { Frequency = 50 };
            Radio radio2 = new Radio() { Frequency = 189, RadioOn = true, Volume = 99 };
            Radio radio3 = new Radio() { Frequency = 399, RadioOn = false, Volume = 2 };
            Console.WriteLine(radio);
            Console.WriteLine(radio2);
            Console.WriteLine(radio3);
            Console.ReadLine();
        }

        private static void RadioClass2()
        {
            Radio radio = new Radio();
            Radio radio2 = new Radio(volume: 64, frequency: 150);            
            Console.WriteLine(radio);
            Console.WriteLine(radio2);
            Console.ReadLine();
        }

        private static void RadioClass()
        {
            Radio radio = new Radio();
            Radio radio1 = new Radio(radioOn: true, volume: 75, frequency: 300);
            Console.WriteLine(radio);
            Console.WriteLine(radio1);
            Console.ReadLine();
        }

        private static void CarClass()
        {
            Car car = new Car();
            Car car1 = new Car(brand: "BMW", numberOfGears: 6, color: "Hotpink", type: "Kupe");  // Suv not a valid car type
            Console.WriteLine(car);
            Console.WriteLine(car1);
            Console.ReadLine();
        }
    }
}
