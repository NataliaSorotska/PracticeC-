using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance= new DerivedClass();
           instance.Method();
            instance.NoVirtualMethod();
            BaseClass instanceUp = instance;
            instanceUp.Method();
            instanceUp.NoVirtualMethod();
            DerivedClass instanceDown = (DerivedClass) instanceUp;
            instanceDown.Method();
            instanceDown.NoVirtualMethod();
            Console.ReadKey();
        }
    }
   

    
}
