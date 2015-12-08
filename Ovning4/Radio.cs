using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning4
{
    class Radio
    {
        private static int instanceCount;
        private double frequency;
        private int volume;
        private bool radioOn;
        public static int InstanceCount
        {
            get { return instanceCount; }

        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                var validFrequency = value >= 0 && value <= 400;
                if (validFrequency)
                    frequency = value;
                else
                    throw new Exception("Not a valid frequency!");
            }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                var validVolume = value >= 0 && value <= 100;
                if (validVolume)
                    volume = value;
                else
                    throw new Exception("Not a valid volume!");
            }
        }
        public bool RadioOn
        {
            get { return radioOn; }
            set { radioOn = value; }
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            Frequency = 0;
            Volume = 0;
            RadioOn = false;
            instanceCount++;
        }
        public Radio(bool radioOn, int volume, double frequency):this()
        {
            RadioOn = true;
            Volume = volume;
            Frequency = frequency;
        }
        public Radio(int volume, double frequency) : this()
        {
            Frequency = frequency;
            Volume = volume;

        }

        public override string ToString() => $"Radio on? {RadioOn}.\nVolume: {Volume} %\nFrequency: {Frequency}Hz\nInstance count: {instanceCount}";

    }
}
