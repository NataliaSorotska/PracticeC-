using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    interface IInterface
    {
        void Method();
    }

    //abstract class AbstractClass : IInterface
    //{
    //    public abstract void Method();

    //}

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }
    class ConcreteClass: BaseClass ,IInterface //AbstractClass
    {
       
    }

    class Program
    {


        static void Main(string[] args)
        {

            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            IInterface instance1= instance as IInterface;
            instance1.Method();
            Console.ReadKey();

        }



    }
}




