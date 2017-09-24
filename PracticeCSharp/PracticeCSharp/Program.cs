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

        static void Main(string[] args)
        {
            var array = new[] {1, 2, 3, 4, 5};
            Console.WriteLine(array.GetType());

            var array2 = new[] {3.1415, 1, 6};
            Console.WriteLine(array2.GetType());

            Console.ReadKey();

        }



    }
}




