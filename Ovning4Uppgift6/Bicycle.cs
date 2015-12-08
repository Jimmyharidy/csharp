using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4Uppgift6
{
    public class Bicycle
    {
        //Backingfields
        static int instanceCount;
        string brand;
        int numberOfGears;
        string style;        
        int currentGear;
        //Properties
        public static int InstanceCount
        {
            get { return instanceCount; }
            private set { instanceCount = value; }

        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                var validNumberOfGears = value >= 1 && value <= 21;
                if (validNumberOfGears)
                    numberOfGears = value;
                else
                    throw new Exception("Not a valid gear!");
            }
        }
        public string Style
        {
            get { return style; }
            set
            {
                var validBikeTypes = value == "Mountain bike" || value == "Racing bike" || value == "BMX bike";
                if (validBikeTypes)
                    style = value;
                else
                    throw new Exception("Not a valid bike type!");
            }
        }
        public int CurrentGear
        {
            get { return currentGear; }
            set { currentGear = value; }
        }
        //Constructors
        static Bicycle()
        {
            InstanceCount = 0;
        }
        public Bicycle()
        {
            Brand = "Crescent";
            NumberOfGears = 3;
            Style = "BMX bike";
            InstanceCount++;
            Random randomGear = new Random();
            CurrentGear = randomGear.Next(NumberOfGears);
        }        
        public Bicycle(string brand, int numberOfGears, string style) : this()
        {
            Brand = brand;
            NumberOfGears = numberOfGears;
            Style = style;
        }
        //Methods
        public void Pling()
        {
            Console.Beep(2000, 500);
        }
        //ToString (Method)
        public override string ToString() => $"Brand: {Brand}\nNumber of gears: {NumberOfGears}\nType: {Style}\nYou changed gear to: {CurrentGear}\nInstance count: {InstanceCount}";
    }
}

