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
            //ClearList();
            //IndexOfMethod();
            //SortingPlaneList();

          

        }

        private static void SortingPlaneList()
        {
            var planes = new List<Airplane>()
           {
               new Airplane(seats:2, pilots:5),
               new Airplane(seats:4, pilots:10),
               new Airplane(seats:6, pilots:1),
               new Airplane(seats:8, pilots:15),
               new Airplane(seats:10, pilots:0),
               new Airplane(seats:1, pilots:7),
               new Airplane(seats:0, pilots:5),
               new Airplane(seats:3, pilots:9),
               new Airplane(seats:6, pilots:13)
           };
            planes.Sort();
            planes.Reverse();
            foreach (var airplane in planes)
            {
                Console.WriteLine(airplane);
            }
            Console.ReadLine();
        }

        private static void IndexOfMethod()
        {
            List<int> tal = new List<int>
                                    (new int[] { 3, 2, 3, 2, 29, 33, 33, 32 });
            int indexPosition = tal.IndexOf(29);  // position 4 är första förekomsten av 29. 
            Console.WriteLine(indexPosition);  // skriver 4
            indexPosition = tal.IndexOf(17);
            Console.WriteLine(indexPosition);  // skriver ut -1 för att talet 17 finns ej.
            Console.ReadLine();
        }

        private static void ClearList()
        {
            var lista = new List<Boolean>() { true, false, false, true };
            lista.Add(true);
            lista.Add(false);
            lista.Add(true);
            lista.Add(true);
            Console.WriteLine(lista.Count);  // antal element
            lista.Clear();  // Raderar lista
            Console.WriteLine(lista.Count);
            Console.ReadLine();
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
