using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method for Base Class");
        }

        public void NoVirtualMethod()
        {
            Console.WriteLine("No virtual Base Class");
        }
    }
}
