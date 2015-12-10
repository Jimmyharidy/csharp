using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructOperatorOverlagring
{
    class Program
    {
        static void Main(string[] args)
        {
            Cycle timCycle = new Cycle(3, 21);
            Cycle zebbeCycle = new Cycle(1, 2);
            zebbeCycle += 12;
            Console.WriteLine(zebbeCycle);
            zebbeCycle -= 1;
            Console.WriteLine(zebbeCycle);
            Console.ReadLine();
        }
    }
}
