using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvMedOlikaKonstruktors
{
    class Child:Person
    {

        private int adults;
        private int children;
        public int Adults
        {
            get { return adults; }
            set { adults = value; }
        }

        public int Children
        {
            get { return children; }
            set { children = value; }
        }

        public Child()
        {
            Adults = 2;
            children = 3;
        }

        public Child(int adults, int children, string name, int age) :base(name,age)
        {
            Adults = adults;
            Children = children;
        }

        public override string ToString() => $"{base.ToString()}\nAdults: {Adults}\nChildren: {Children}";
    }
}
