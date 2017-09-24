using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    interface IInterface1
    {
        // void Method1();
        void Method();
    }

    interface IInterface2 : IInterface1
        {
            // void Method2();
           new void Method();
        }

        class ConcreteClass : IInterface2
        {
            //public void Method1()
            //{
            //    Console.WriteLine("Method1 in Interface1");
            //}
            //public void Method2()
            //{
            //    Console.WriteLine("Method1 in Interface2");
            //}

            void IInterface1.Method()
            {
                Console.WriteLine("Method in Interface1");
            }
            void IInterface2.Method()
            {
                Console.WriteLine("Method in Interface2");
            }

        }
        class Program
        {


            static void Main(string[] args)
            {
                //Interface1 interface1= new DericedClass();
                //Interface2 interface2 = new DericedClass();
                //interface1.Method1();
                //interface2.Method2 ();
                // ______________________________________________________
                //DericedClass instance= new DericedClass();
                //instance.Method();
                //instance.Method1();
                //instance.Method2();

                //Console.WriteLine(new string('-',40));

                //BaseClass instance0= instance as BaseClass;
                //instance0.Method();

                //Interface1 instace1=instance as Interface1;
                //instace1.Method1();

                //Interface2 instace2 = instance as Interface2;
                //instace2.Method2();
                ////_________________________________________________________

            ConcreteClass instance = new ConcreteClass();
            IInterface1 instance1= instance as IInterface1;
            instance1.Method();

            IInterface2 instance2= instance as IInterface2;
            instance2.Method();


                Console.ReadKey();

            }



        }
    }




