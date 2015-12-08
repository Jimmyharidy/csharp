using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_5
{
    class Juice : EcoStockItem
    {
        string flavor;
       

        public string Flavor
        {
            get { return flavor; }
            set
            {
                if (value == "Apple" || value == "Orange")
                    flavor = value;
                else
                {
                    throw new Exception("Not a valid input!");
                }
            }
        }
        public override string ToString()
        {
            return $"Flavor: {flavor}" + base.ToString();
        }
    }
    
}
