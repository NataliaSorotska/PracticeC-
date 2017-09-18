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
            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;
            instance.field4 = 4;
            instance.field5 = 5;
            BaseClass newInstance = (BaseClass) instance;
            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            Console.WriteLine($"Instance id {instance.GetHashCode()}");
            Console.WriteLine($"newInstance id {newInstance.GetHashCode()}");
            Console.ReadKey();
        }
    }
   

    
}
