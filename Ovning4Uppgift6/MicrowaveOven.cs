using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4Uppgift6
{
    class MicrowaveOven
    {
        private string brand;
        private string color;
        private double height;
        private double width;
        private double depth;
        private double weight;
        private int effect;
        private double volume;
        private bool rotatingPlate;
        public string Brand
        {
            get { return brand; }
            set {
                if (value !=null && value != "")    // Kolla denna kod?
                    brand = value;
                else
                    throw new Exception("Not a valid brand!");

            }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 15)
                    weight = value;
                else
                    throw new Exception("Not a valid weight!");
            }
        }

        public int Effect
        {
            get { return effect; }
            set {
                if (value <= 1000)
                    effect = value;
                else
                    throw new Exception("Not a valid effect!");
            }
        }

        public double Volume
        {
            get { return volume; }
            set {
                if (value > 15 || value <= 25)
                    volume = value;
                else
                    throw new Exception("Not a valid volume!");
            }
        }

        public bool RotatingPlate
        {
            get { return rotatingPlate; }
            set { rotatingPlate = value; }
        }
        public MicrowaveOven()
        {
            Brand = "Whirlpool";
            Color = "Silver Metallic";
            Height = 40;
            Width = 70;
            depth = 30;
            Weight = 10;
            Effect = 1000;
            Volume = 22;
            RotatingPlate = true;
        }
        public MicrowaveOven(string brand, string color, double height, double width, double depth):this()
        {
            Brand = brand;
            Color = color;
            Height = height;
            Width = width;
            Depth = depth;
        }
        public MicrowaveOven(string brand, string color, double height, double width, double depth, double weight, int effect, double volume, bool rotatingPlate)
        {
            Brand = brand;
            Color = color;
            Height = height;
            Width = width;
            Depth = depth;
            Weight = weight;
            Effect = effect;
            Volume = volume;
            RotatingPlate = rotatingPlate;

        }
        public override string ToString() => $"Brand: {Brand}\nColor: {Color}\nHeight: {Height} Cm\nWidth: {Width} Cm\nDepth: {Depth} Cm\nWeight: {Weight} Kg\nEffect: {Effect} Watt\nVolume: {Volume} Liter\nRotatingplate: {RotatingPlate}";

    }
}
