using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WareHouseMethod();
        }

        private static void WareHouseMethod()
        {
            int stockItemChoice;
            bool validInput = false;
            int itemChoice;
            Stock stock = new Stock();
            bool loopa = true;
            while (loopa)
            {

                Menu.PrintMainMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case ("1"):
                        stockItemChoice = CreateStockItem(stock);
                        break;
                    case ("2"):
                        InventoryItems(out validInput, out itemChoice, stock);
                        break;
                    case ("3"):
                        ListAllItems(stock);
                        break;
                    case ("4"):
                        loopa = ExitLoop();
                        break;
                    default:
                        Console.WriteLine("You picked an invalid option!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool ExitLoop()
        {
            bool loopa;
            Console.WriteLine("stop ");
            loopa = false;
            return loopa;
        }

        private static void ListAllItems(Stock stock)
        {
            Console.WriteLine("Lista Varor");
            for (int i = 0; i < stock.stockItems.Length; i++)
            {
                if (stock.stockItems[i] is EcoStockItem && stock.stockItems[i] != null)
                {
                    Console.WriteLine(stock.GetItem(i));

                }
                else if (stock.stockItems[i] != null)
                {
                    Console.WriteLine(stock.GetItem(i));
                }
            }
        }

        private static void InventoryItems(out bool validInput, out int itemChoice, Stock stock)
        {
            Console.WriteLine("Inventera varor");
            for (int i = 0; i < stock.stockItems.Length; i++)
            {
                if (stock.stockItems[i] != null)
                {
                    Console.WriteLine(i.ToString() + " " + stock.GetItem(i));
                    Console.WriteLine("Välj en vara genom att skriva dess nummer.");
                }
            }
            validInput = int.TryParse(Console.ReadLine(), out itemChoice);
            if (validInput == true)
            {
                Console.WriteLine("Skriv in din ändrade stock count");
                stock.stockItems[itemChoice].StockCount = int.Parse(Console.ReadLine());
            }
            else throw new Exception("Invalid input! Write a number!");
        }

        private static int CreateStockItem(Stock stock)
        {
            int stockItemChoice;
            Console.WriteLine("1- Create stock item");
            Console.WriteLine("2- Create Juice");
            Console.WriteLine("3- Create Plate");
            stockItemChoice = int.Parse(Console.ReadLine());
            if (stockItemChoice == 1)
            {
                Console.WriteLine("Create stockitem and add to stock");
                Console.WriteLine("Write the number of the item in stock and name of the item in that order");
                StockItem newItem = new StockItem() { Id = stock.counter, StockCount = int.Parse(Console.ReadLine()), Name = Console.ReadLine() };
                stock.AddItem(newItem);
            }
            else if (stockItemChoice == 2)
            {
                Console.WriteLine("Create stockitem and add to stock");
                Console.WriteLine("Write the eco mark EG or Krav, the flavour of the juice, the number of the item in stock and name of the item in that order");
                Juice newJuice = new Juice() { Mark = Console.ReadLine(), Flavor = Console.ReadLine(), Id = stock.counter, StockCount = int.Parse(Console.ReadLine()), Name = Console.ReadLine() };
                stock.AddItem(newJuice);
            }
            else if (stockItemChoice == 3)
            {
                Console.WriteLine("Create stockitem and add to stock");
                Console.WriteLine("Write the shape of the plate, the number of the item in stock and name of the item in that order");
                Plate newPlate = new Plate() { Shape = Console.ReadLine(), Id = stock.counter, StockCount = int.Parse(Console.ReadLine()), Name = Console.ReadLine() };
                stock.AddItem(newPlate);
            }

            return stockItemChoice;
        }
    }
}



