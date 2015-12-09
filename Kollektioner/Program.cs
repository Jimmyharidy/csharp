using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista1();
            //Lista2();
            //BussLista();
            //FlygplanLista();
            //SingleFlyg();
        }

        private static void SingleFlyg()
        {
            var jas39 = new Airplane(seats: 5, pilots: 2);
            var jas40 = new Airplane(seats: 7, pilots: 0);
            var planes = new List<Airplane>() { jas39, jas40 };
            Console.WriteLine(planes);
            Console.ReadLine();  // Kolla denna kod.
        }

        private static void FlygplanLista()
        {
            var planes = new List<Airplane>();
            for (int i = 0; i < 50; i++)
            {
                planes.Add(new Airplane(200 + i, i % 3));
            }
            foreach (var airplane in planes)
            {
                Console.WriteLine(airplane);
            }
            Console.ReadLine();
        }

        private static void BussLista()
        {
            var busses = new List<Buss>();
            for (int i = 0; i < 50; i++)
            {
                busses.Add(new Buss(i + 300, i % 20));
            }
            foreach (var buss in busses)
            {
                Console.WriteLine(buss);
            }
            Console.ReadLine();
        }

        private static void Lista2()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 50; i++)
            {
                persons.Add(new Person("Name" + i, i % 30));
            }
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }

        private static void Lista1()
        {
            var lisa = new Person("Lisa", 26);
            var raffe = new Person("Rafael", 44);
            List<Person> persons = new List<Person>();
            persons.Add(lisa);
            persons.Add(raffe);
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }
}
