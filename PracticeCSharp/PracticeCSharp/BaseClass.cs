using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    abstract class AbstractaseClass
    {
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractClass.SimpleMethod");
        }

        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractClass.VirtualMethod");
        }

        abstract public void AbstractMethod();

    }
}
