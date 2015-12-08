using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uppgift1_1();
            Uppgift1_2();
            Uppgift1_3();

        }

        private static void Uppgift1_3()
        {
            string name = "Jonas";
            string town = "Helsingborg";
            string area = "Stattena";
            string atPlace = "Hemköp";
            string[] informationArray = new string[4] { name, town, area, atPlace };
            string print = string.Format ("Han heter {0} och bor i {1} på {2} vid {3}", name, town, area, atPlace );
            Console.WriteLine(print);
            name = "Kalle";
            town = "Malmö";
            area = "Olympia";
            atPlace = "Fotbollsarenan";
            print = ("Jag heter " + name + " och bor i " + town + " på " + area + " vid " + atPlace);
            Console.WriteLine(print);
        }

        private static void Uppgift1_2()
        {
           const double PIABOUT = 3.141592654;
            double piRound = 3.14;
            string print = string.Format("Talet pi är cirka " + PIABOUT + " men kan avrundas till " + piRound + " och kan lite grovt skrivas som " + Math.Floor(piRound));
            Console.WriteLine(print);
           // PIABOUT = 5.141296;  Går inte att ändra konstanter!
            piRound = 5.14;
            print = ("Talet " + PIABOUT + " kan avrundas till " + piRound + " men kan även avrundas ner till " + Math.Floor(piRound));
            Console.WriteLine(print);
        }

        private static void Uppgift1_1()
        {
            double dowJones = 4.6;
            double nasdaq = 4.1;
            double stockholm = -2.4;
            double milano = -6.7;
            double paris = -5.5;

            double[] stockArray = new double[5] { dowJones, nasdaq, stockholm, milano, paris };
            string print = string.Format("Dow Jones sjönk med {0} procent och Nasdaq sjönk med {1} procent. Stockholm {2} procent, Milano {3} procent, paris {4} procent. ", dowJones, nasdaq, stockholm, milano, paris);
            Console.WriteLine(print);
            dowJones = 3.7;
            nasdaq = 3.1;
            stockholm = -1.9;
            milano = -4.4;
            paris = 5.2;
            print = ("Dow Jones höjdes med " + dowJones + " procent, " + "Nasdaq höjdes med " + nasdaq + " procent, " + "Stockholm sjönk " + stockholm + " procent, " + "Milano sjönk " + milano + " procent, " + "Paris höjdes med " + paris + " procent ");
            Console.WriteLine(print);
        }

    }
}
