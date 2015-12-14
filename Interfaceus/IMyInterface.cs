using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceus
{
   internal interface IMyInterface

    {
       //void Method()
       //{
       //    // Kan ej implementera ett interface / kontrakt
       //    Console.WriteLine("Hej");
       //}
    }

    class MyClass : IMyInterface
    {
        // Enligt kontraktet med interface måste vi skapa en metodkropp som hanterar
        // den metod som är deklarerad i interfacet

    }
}
