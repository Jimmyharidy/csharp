using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableNogonting
{
    class MyClass: IComparable<MyClass>
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }

        public MyClass(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public int CompareTo(MyClass other)
        {
            return Age.CompareTo(other.Age);
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}, Gender: {Gender}";
       
    }
}
