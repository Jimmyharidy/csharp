﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    struct MyDoubleType
    {
        private double doubleValue;

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

        public static bool operator ==(MyDoubleType value, double value2)  // Kolla koden
        {

            return false;
            //if (value == value)
            //{
            //    return false;
            //}
            //else
            //    return true;


        }
        public static bool operator !=(MyDoubleType value, double value2)
        {
            return !(value == value2);
        }

        public override string ToString() => $"Double value: {doubleValue}";
    }
}
