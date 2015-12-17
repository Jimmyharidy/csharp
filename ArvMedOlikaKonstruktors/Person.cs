using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedOlikaKonstruktors
{
    class Person
    {
        private string gender;
        private string name;
        private int age;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
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

        public Person()
        {
            Gender = "male";
            Name = "Jimmy";
            Age = 31;
        }

        public Person(string name, int age):this()
        {
            
            Name = name;
            Age = age;
        }

        public override string ToString() => $"Gender: {Gender}\nName: {Name}\nAge: {Age}";
    }
}
