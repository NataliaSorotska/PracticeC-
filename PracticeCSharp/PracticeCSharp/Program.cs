using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Program
    {
        //class ConcreteClassA
        //{
        //    public void Operation()
        //    {
        //        Console.WriteLine("ConcreteClassA.Operation");
        //    }
        //}
        //abstract class AbstractClass : ConcreteClassA
        //{
        //    public abstract void Method();
        //}

        //class ConcreteCkassB:AbstractClass
        //{
        //    public override void Method()
        //    {
        //        Console.WriteLine("ConcreteClassB.Method");
        //    }
        //}

//_________________________________________________________________

        //    abstract class AbstractClassA
        //    {
        //        public abstract void OperationA();
        //    }
        //abstract class AbstractClassB:AbstractClassA
        //{
        //    public abstract void OperationB();
        //}

        //class ConcreteClass:AbstractClassB
        //{
        //    public override void OperationA()
        //    {
        //        Console.WriteLine("ConcreteClass.OperationA");
        //    }
        //    public override void OperationB()
        //    {
        //        Console.WriteLine("ConcreteClass.OperationB");
        //    }
        //}

  //------------------------------------------------------
        static void Main(string[] args)
        {
            //AbstractClass instance= new ConcreteCkassB();
            //instance.Method();
            //instance.Operation();
            //_______________________________________________________________________
            //AbstractClassA instance = new ConcreteClass();
            //AbstractClassB inctanceB= new ConcreteClass();
            //inctanceB.OperationB();
            //inctanceB.OperationA();
            //instance.OperationA();
//------------------------------------------------------
    
           //ConcreteDericedClass instance = new ConcreteDericedClass();
           // instance.SimpleMethod();
           // instance.VirtualMethod();
           // instance.AbstractMethod();

            AbstractClass instance = new ConcreteClass();
            Console.WriteLine(new string('-',55));
            instance.AbstractMethod();

            Console.ReadKey();

        }

       abstract class AbstractClass
       {
           public AbstractClass()
           {
               Console.WriteLine("1 AbstractClass()");
               this.AbstractMethod();
               Console.WriteLine("2 AbstractClass()");
           }

           public abstract void AbstractMethod();

       }

        class ConcreteClass:AbstractClass
        {
            private string s = "FIRST";

            public ConcreteClass()
            {
                Console.WriteLine("3 ConcreteClass()");
                s = "SECOND";

            }

            public override void AbstractMethod()
            {
                Console.WriteLine($"Realization Method  AbstractMethod() in ConcreteClass {s}");
            }
        }

       

    }
}




