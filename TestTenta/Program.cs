using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTenta
{
    class Program
    {
        static void Main(string[] args)
        {
           Teachers teacher1 = new Teachers() {Name = "Jimmy", Position = "Helsingborg"};
            Teachers teacher2 = new Teachers();
            List<Teachers> teacherList = new List<Teachers>();
            teacherList.Add(teacher1);
            teacherList.Add(teacher2);
            teacherList.Sort();
            Console.WriteLine(teacherList);
            Console.ReadLine();
        }
    }
}
