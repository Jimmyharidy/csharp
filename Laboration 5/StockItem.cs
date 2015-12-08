using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_5
{
    public class StockItem
    {
        int id;
        int stockCount;
        string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int StockCount
        {
            get { return stockCount; }
            set { stockCount = value; }
        }

        public string Name
        {
            get { return name; }
            set {
                if(value != null)
                name = value;
                else throw new Exception ("You dinnae write a naem!");
            }
        }
        public override string ToString()
        {
            return $"ID: {id}, Stock count: {stockCount}, Name: {name}";
        }
    }
}
