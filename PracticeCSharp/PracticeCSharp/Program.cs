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
            BaseClass instanceUp = instance;
            instanceUp.Method();
            DerivedClass instanceDown = (DerivedClass) instanceUp;
            instanceDown.Method();
            Console.ReadKey();
        }
    }
   

    
}
