using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Ovning3;

namespace OvningArv
{
    class Point3D : Point
    {
        private int z;

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
           
        }

        public Point3D()
        {
            Z = 25;
        }

        public Point3D(int z, int x, int y) : base(x, y)
        {
            Z = z;
            
            
        }

        public override string ToString() => $"Z: {z}\n{base.ToString()}";

    }
}
