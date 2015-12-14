using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOvning
{
    enum Menu
    {
        Ett=1, Tvau, End
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            bool loopa = true;
            do
            {
                int tal;
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    Menu menu = (Menu) tal;
                    switch (menu)
                    {
                        case Menu.Ett:
                            int tal1;
                            int tal2;
                            Console.WriteLine("Skriv in två tal som skall adderas:");
                            if (int.TryParse(Console.ReadLine(), out tal1)
                                && int.TryParse(Console.ReadLine(), out tal2))
                            {
                                Console.WriteLine("{0}+{1}={2}",tal1, tal2, tal1 + tal2 );
                            }
                            break;
                        case Menu.Tvau:
                            int tal3;
                            int tal4;
                            Console.WriteLine("Skriv in två tal som skall multipliceras med varandra");
                            if(int.TryParse(Console.ReadLine(), out tal3) 
                                && int.TryParse(Console.ReadLine(), out tal4))
                        {
                            Console.WriteLine("{0}*{1}={2}", tal3, tal4, tal3 * tal4);
                        }
                            break;
                        case Menu.End:
                            loopa = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid choice!");
                            break;
                    }
                }
            } while (loopa);
            Console.ReadLine();
        }

        private static void PrintMenu()
        {
            int counter = 1;
            foreach (var items in Enum.GetNames(typeof (Menu)))
            {
                Console.WriteLine("{0}:{1}", counter++, items);
            }
            Console.WriteLine("Please enter a number from the list above:");
        }
    }
}
