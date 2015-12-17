using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedOlikaKonstruktors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Child child1 = new Child();
            Console.WriteLine(person1);
            Console.WriteLine(child1);
            Console.ReadLine();
        }
    }
}
