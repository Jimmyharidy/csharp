using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Car
    {
        private string brand;
        private int numberOfGears;
        private string color;
        private string type;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set { numberOfGears = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Type
        {
            get { return type; }
            set {
                
               if(value.ToLower() == "kombi" || value.ToLower() == "kupe")
                    type = value.ToLower();
                else
                    throw new Exception("Not a valid car type!");
            }
        }
        public Car()
        {
            Brand = "Volvo";
            NumberOfGears = 5;
            Color = "Red";
            Type = "Kupe";
        }
        public Car(string brand, int numberOfGears, string color, string type)
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Color = color;
            Type = type;
        }
        public override string ToString() => $"Brand: {Brand}\nNumber of gears: {NumberOfGears}\nColor: {Color}\nType: {Type}";
    }
}
