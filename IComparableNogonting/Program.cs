using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IComparableNogonting
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var lista = new List<MyClass>();
            lista.Add(new MyClass("Jimmy", 31, "Male"));
            lista.Add(new MyClass("Jimbo", 87, "Male"));
            lista.Add(new MyClass("Jonna", 15, "Female"));
            lista.Add(new MyClass("Johanna", 1, "Female"));
            lista.Add(new MyClass("Olivia", 28, "Female"));
            lista.Sort();
            lista.ForEach(Console.WriteLine);


            // Skapa en POCO - Klass med tre attribute
            // Lägg 5 av klassen i en kollektion
            // Använd sort() på kollektionen
        }
    }
}
