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
          int[][] jagged= new int[3][];
            jagged[0] = new[] {1, 2};
            jagged[1] = new[] {1, 2, 3, 4, 5};
            jagged[2] = new[] {1, 2, 3};

            for (int i = 0; i <jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }



    }
}




