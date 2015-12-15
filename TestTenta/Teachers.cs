using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTenta
{
    public class Teachers: IComparable<Teachers>
    {
       private string name;
      private string position;

        //public string Name
        //{
        //    get {return name;}
        //    set { name = value;}
        //}

        //public string Position
        //{
        //    get {return position ; }
        //    set { position = value; }
        //}

        public string Name { get; set; }
        public string Position { get; set; }

        public Teachers()
        {
            Name = "Adolf";
            Position = "Tyskland";
        }

        public Teachers(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public int CompareTo(Teachers obj)
        {
            return obj.Name.CompareTo(this.Name);
        }

        public override string ToString() => $"Name: {Name}\r\nPosition: {Position}";
    }

}
