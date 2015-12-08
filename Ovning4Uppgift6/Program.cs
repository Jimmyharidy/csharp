using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4Uppgift6
{
    class Program
    {
        static void Main(string[] args)
        {
            //BicycleMethod();
            MicrowaveOven whirlpool = new MicrowaveOven();
            
            try
            {
                MicrowaveOven obhNordica = new MicrowaveOven("OBH Nordica", "White", 25.7, 35.6, 30.5);
                Console.WriteLine(whirlpool);
                Console.WriteLine(obhNordica);
                //int i = int.Parse("number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
            
        }

        private static void BicycleMethod()
        {
            Bicycle bicycle1 = new Bicycle();
            Bicycle bicycle2 = new Bicycle(brand: "Monark", numberOfGears: 18, style: "Mountain bike");
            Bicycle bicycle3 = new Bicycle(brand: "Crescent", numberOfGears: 21, style: "Racing bike");
            Console.WriteLine(bicycle1);
            Console.WriteLine(bicycle2);
            Console.WriteLine(bicycle3);
            bicycle1.Pling();
            bicycle2.Pling();
            bicycle3.Pling();

            Console.ReadLine();
        }
    }
}
