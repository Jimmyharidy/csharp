using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_5
{
   public class EcoStockItem : StockItem
    {
        string mark;

        public string Mark
        {
            get { return mark; }
            set {
                if(value == "EG" || value == "Krav")
                    mark = value;
            }
        }
        public override string ToString() => $"Mark: {mark}, " + base.ToString();
       

    }
}
