using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class ConcreteDericedClass:AbstractaseClass
    {
        //public override void VirtualMethod()
        //{
        //    Console.WriteLine("DeriverClass.Virtualethod()");
        //}

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod()");
        }


    }
}
