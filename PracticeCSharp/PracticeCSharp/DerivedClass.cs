using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            
            Console.WriteLine("Method for Derived Class");
        }
        public void NoVirtualMethod()
        {
            Console.WriteLine("No virtual Derived Class");
        }
    }

}


