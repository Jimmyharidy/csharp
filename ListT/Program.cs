using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingLists();

        }

        private static void SortingLists()
        {
            var lista = new List<Animal>();
            lista.Add(new Animal());
            lista.Add(new Animal("Tiger", "Tigris", 5));
            lista.Add(new Animal("Jaguar", "Jagis", 2));
            lista.Add(new Animal("Hund", "Vovvov", 3));
            lista.Sort();
            //lista.Reverse();
            foreach (var items in lista)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
}
