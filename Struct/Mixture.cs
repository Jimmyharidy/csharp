using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Mixture
    {
       public bool MyBool;
       public double MyDouble;
       public Int64 Myint;

        // Går ej att göra en tom konstructor
        //public Mixture()
        //{
            
        //}
        public Mixture(bool myBool, double myDouble, Int64 myInt)
        {
            MyBool = myBool;
            MyDouble = myDouble;
            Myint = myInt;
        }

        public override string ToString() => $"MyBool: {MyBool}\nMyDouble: {MyDouble}\nMyInt: {Myint}";
    }
}
