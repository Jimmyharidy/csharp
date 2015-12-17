using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchWithEnum
{
    enum Menu { Val1 = 1, Val2, Val3, End }
    class Program
    {

        static void Main(string[] args)
        {
            CreateMenu();
            bool loopa = true;
            do
            {


                {
                    int tal;
                    if (int.TryParse(Console.ReadLine(), out tal))
                    {
                        Menu menu = (Menu) tal;
                        switch (menu)
                        {
                            case Menu.Val1:
                                Console.WriteLine("Option one was selected");
                                break;
                            case Menu.Val2:
                                Console.WriteLine("Option two was selected");
                                break;
                            case Menu.Val3:
                                Console.WriteLine("Option three was selected");
                                break;
                            case Menu.End:
                                loopa = false;
                                break;
                            default:
                                throw new Exception("Please enter a valid option!");
                        }
                    }
                }
            } while (loopa);
            Console.ReadLine();
        }


        private static void CreateMenu()
        {
            int counter = 1;
            foreach (var items in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("{0}:{1}", counter++, items);
                
            }
            Console.WriteLine("Please select an option!");
            
           
        }
    }
}
