using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program 
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Snälla du, skriv in ett produktnamn:");
                var name = Console.ReadLine();
                Console.WriteLine("Antal");
                var quantity = int.Parse(Console.ReadLine());
                products.Add(new Product(name,quantity));
            }
            products.Sort();
            Console.WriteLine("Vilket tal är min?");
            var min = int.Parse(Console.ReadLine());

            foreach (var product  in products)
            {
                if (product.Quantity > min)
                {
                    Console.WriteLine(product);
                }
                Console.ReadLine();
            }
        }
    }
}
