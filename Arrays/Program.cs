using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i*20;
                Console.WriteLine("Strange value {0} = {1}", i, myArray[i]);
            }
            Console.ReadLine();


        }
        
    } 
}
