using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    struct MyDoubleType
    {
        private double doubleValue;
        //public string ExtraPropFor { get; set; }

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            this.doubleValue = doubleValue;

        }


        public static MyDoubleType operator +(MyDoubleType value, double value2)
        {
            value.doubleValue += value2;
            return value;

        }

        public static MyDoubleType operator +(MyDoubleType value, MyDoubleType value2)
        {
            value.doubleValue += value2.doubleValue;
            return value;
        }

        public static MyDoubleType operator -(MyDoubleType value, double value2)
        {
            value.doubleValue -= value2;
            return value;
        }

        public static MyDoubleType operator -(MyDoubleType value, MyDoubleType value2)
        {
            value.doubleValue -= value2.doubleValue;
            return value;
        }

        public static MyDoubleType operator *(MyDoubleType value, double value2)
        {
            value.doubleValue *= value2;
            return value;
        }

        public static MyDoubleType operator *(MyDoubleType value, MyDoubleType value2)
        {
            value.doubleValue *= value2.doubleValue;
            return value;
        }

        public static MyDoubleType operator /(MyDoubleType value, double value2)
        {
            value.doubleValue /= value2;
            return value;
        }

        public static MyDoubleType operator /(MyDoubleType value, MyDoubleType value2)
        {
            value.doubleValue /= value2.doubleValue;
            return value;
        }

        public static bool operator ==(MyDoubleType value, MyDoubleType value2) 
        {

            return value2.doubleValue.Equals(value.doubleValue);
            
            

        }
        public static bool operator !=(MyDoubleType value, MyDoubleType value2)
        {
            return !value.DoubleValue.Equals(value2);
        }

        public static bool operator <(MyDoubleType value, MyDoubleType value2)
        {
            return (value.doubleValue < value2.doubleValue);

        }

        public static bool operator >(MyDoubleType value, MyDoubleType value2)
        {
            return value.doubleValue > value2.doubleValue;
        }

        public static bool operator <=(MyDoubleType value, MyDoubleType value2)
        {
            return value.doubleValue <= value2.doubleValue;
        }

        public static bool operator >=(MyDoubleType value, MyDoubleType value2)
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
