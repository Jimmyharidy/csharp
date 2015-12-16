using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOvningExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarMethod();
            Radio radio = new Radio() {Volume = 100, Frequence = 150, RadioOn = true};
            //Radio radiod = new Radio();
            //Radio radioExtra = new Radio(100,100);
            //Radio radio4 = new Radio(99, 199);
            Console.WriteLine(radio);
            //Console.WriteLine(radiod);
            //Console.WriteLine(radioExtra);
            Console.ReadLine();
        }

        private static void CarMethod()
        {
            Bil bil1 = new Bil() { Mark = "Volvo", AntalVaxlar = 5, Color = "Hotpink", Typ = "suv" };
            Console.WriteLine(bil1);
            Console.ReadLine();
        }
    }
}
