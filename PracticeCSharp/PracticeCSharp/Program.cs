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
        static void ShowArray(string name, params int[] array)
        {
            for (int i = 0; i <array.Length ; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }

        static void Main(string[] args)
        {
            ShowArray("Numbers: ",0, 1, 2, 3, 4, 5, 6, 7, 8, 9);


            Console.ReadKey();

        }



    }
}




