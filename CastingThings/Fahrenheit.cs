using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Fahrenheit
    {
        public float Temp { get; set; }

        public Fahrenheit(float temp)
        {
            Temp = temp;
        }
        // Explicit innebär förlust av data(otast en property som inte finns i retur klassen )

        public static implicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius(5.0f/9.0f * fahrenheit.Temp - 32);
        }
    }
}
