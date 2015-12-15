using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class MyDoubleTypeClass
    {
        private double doubleValue;
        //public string ExtraPropFor { get; set; }

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleTypeClass(double doubleValue)
        {
            this.doubleValue = doubleValue;

        }


        public static MyDoubleTypeClass operator +(MyDoubleTypeClass value, double value2)
        {
            return new MyDoubleTypeClass (value.doubleValue + value2);
           

        }

        public static MyDoubleTypeClass operator +(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            return new MyDoubleTypeClass(value.doubleValue + value2.doubleValue);
           
        }

        public static MyDoubleTypeClass operator -(MyDoubleTypeClass value, double value2)
        {
            
            return new MyDoubleTypeClass(value.doubleValue - value2);
        }

        public static MyDoubleTypeClass operator -(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            
            return new MyDoubleTypeClass(value.doubleValue - value2.doubleValue);
        }

        public static MyDoubleTypeClass operator *(MyDoubleTypeClass value, double value2)
        {
            
            return new MyDoubleTypeClass(value.doubleValue * value2);
        }

        public static MyDoubleTypeClass operator *(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            
            return new MyDoubleTypeClass(value.doubleValue * value2.doubleValue);
        }

        public static MyDoubleTypeClass operator /(MyDoubleTypeClass value, double value2)
        {
            
            return new MyDoubleTypeClass(value.doubleValue / value2);
        }

        public static MyDoubleTypeClass operator /(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            
            return new MyDoubleTypeClass(value.doubleValue /= value2.doubleValue);
        }

        public static bool operator ==(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {

            return value2.doubleValue.Equals(value.doubleValue);



        }
        public static bool operator !=(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            return !value.DoubleValue.Equals(value2);
        }

        public static bool operator <(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            return (value.doubleValue < value2.doubleValue);

        }

        public static bool operator >(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            return value.doubleValue > value2.doubleValue;
        }

        public static bool operator <=(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            return value.doubleValue <= value2.doubleValue;
        }

        public static bool operator >=(MyDoubleTypeClass value, MyDoubleTypeClass value2)
        {
            return value.doubleValue >= value2.doubleValue;
        }

        public override string ToString() => $"Double value: {doubleValue}";
        //public override bool Equals(object obj)
        //{
        //    if (obj == null) throw new ArgumentNullException(nameof(obj));
        //    MyDoubleType myt = (MyDoubleType) obj;
        //    return DoubleValue.Equals(myt.DoubleValue);
        //}

        public override int GetHashCode()
        {
            return DoubleValue.GetHashCode();// ^ ExtraPropFor.GetHashCode();
        }
    }
}
