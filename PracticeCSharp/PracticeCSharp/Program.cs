using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Program
    {

        //    sealed class SealedClass
        //    {
        //        public int x;
        //        public int y;
        //    }

        //    class DerivedClass//:SealedClass //Error
        //    {

        //    }
        static void Main(string[] args)
        {
            ClassA instanceA= new ClassA();
            instanceA.Method1();
            instanceA.Method2();
            ClassB instanceB = new ClassB();
            instanceB.Method1();
            instanceB.Method2();
            ClassC instanceC= new ClassC();
            instanceC.Method1();;
            instanceC.Method2();



            //        SealedClass instance = new SealedClass();
            //        instance.x = 100;
            //        instance.y = 200;
            //        Console.WriteLine($"x= {instance.x}, y={instance.y}");

            Console.ReadKey();
        }


        partial class ClassA
        {
            public virtual void Method1()
            {
                Console.WriteLine("ClassA.Method1");
            }

            public virtual void Method2()
            {
                Console.WriteLine("ClassA.Method2");
            }
        }

        partial class ClassA
        {
        }

        class ClassB : ClassA
        {
            sealed public override void Method1()
            {
                Console.WriteLine("ClassB.Method1");
            }

            public override void Method2()
            {
                Console.WriteLine("ClassB.Method2");
            }
        }

        class ClassC : ClassB
        {
            public override void Method2()
            {
                Console.WriteLine("ClassC.Method2");
            }
        }

    }
}




