using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_5
{
    class Plate : StockItem
    {
        private string shape;

        public string Shape
        {
            get { return shape; }
            set {
                if(value == "Flat" || value == "Deep")
                shape = value;
                else
                {
                    throw new Exception("Not a valid input! It must be flat or deep!");
                }

            }
        }
        public override string ToString()
        {
            return $"Shape: {shape}" + base.ToString();
        }
    }
}
