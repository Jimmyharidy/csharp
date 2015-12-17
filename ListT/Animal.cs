using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    class Animal: IComparable<Animal>
    {
        private string kind;
        private string name;
        private int age;
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animal()
        {
            Kind = "Lion";
            Name = "Zimba";
            Age = 7;
        }

        public Animal(string kind, string name, int age)
        {
            Kind = kind;
            Name = name;
            Age = age;
        }

        public int CompareTo(Animal other)
        {
            return Age.CompareTo(other.age);
        }

        public override string ToString() => $"Kind: {Kind}\nName: {Name}\nAge: {Age}";
    }
}
