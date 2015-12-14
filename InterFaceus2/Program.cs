using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceus2
{
    class Program
    {
        static void Main(string[] args)
        {
           Program program = new Program();
            program.ChildMethod();
            program.ParentMethod();
            Console.ReadLine();
        }

        public void ParentMethod()
        {
            Console.WriteLine("Parent");
        }

        public void ChildMethod()
        {
            Console.WriteLine("Child");
        }
    }
}
