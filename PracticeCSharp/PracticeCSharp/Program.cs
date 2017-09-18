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
            DerivedClass instance = new DerivedClass();
            instance.Method();

            BaseClass instanceUp = instance as BaseClass;
            instanceUp.Method();

            DerivedClass instanceDown = instanceUp as DerivedClass;
            instanceDown.Method();

            Console.ReadKey();
        }
    }



}
