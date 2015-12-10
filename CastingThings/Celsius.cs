using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Celsius
    {
        public float Temp { get; private set; }

        public Celsius(float temp)
        {
            Temp = temp;
        }
        // Vi skall skapa en typkonvertering explicit typkonvertering som returnerar en Fahrenheit
        public static implicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit((9.0f/5.0f)* celsius.Temp + 32);
        }
    }
}
