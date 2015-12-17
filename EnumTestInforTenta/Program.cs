using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumTestInforTenta
{
    enum Menu { Val1=1, Val2,Val3, End}
    class Program
    {
        List<Menu> menu = new List<Menu>();        
        static void Main(string[] args)
        {
            
            int counter = 1;
            foreach (var name in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine($"{counter++} {name}");
            }
            Console.WriteLine("Välj ett av valen!");
            bool loopa = true;
            do
            { 
            int tal;
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    Menu menu = (Menu) tal;
                    switch (menu)
                    {
                        case Menu.Val1:
                            Console.WriteLine("Du kan detta superbra");
                            break;
                        case Menu.Val2:
                            Console.WriteLine("Du kan detta si och så");
                            break;
                        case Menu.Val3:
                            Console.WriteLine("Du kan inte detta alls");
                            break;
                            case Menu.End:
                            loopa = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                }
            }
                while (loopa) ;
                Console.ReadLine();
            
        }
    }
}
