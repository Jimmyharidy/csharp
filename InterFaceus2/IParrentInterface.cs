using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceus2
{
    internal interface IParrentInterface
    {
        void ParentMethod();
    }

    interface IChildInterface : IParentInterface
    {
        
    }

    internal interface IParentInterface
    {
    }
}
