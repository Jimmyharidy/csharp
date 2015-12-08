using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_5
{
    public class Stock
    {
        public int counter = 0;
        public StockItem[] stockItems = new StockItem[100];
        public StockItem this[int index]
        {
            get { return stockItems[index]; }
            private set { stockItems[index] = value; }
        }
        public void AddItem(StockItem item)
        {
            if (counter < stockItems.Length)
            {
                this[counter] = item;
                counter++;
            }
        }
        public StockItem GetItem(int itemId)
        {
            return stockItems[itemId];

        }
    }
}
