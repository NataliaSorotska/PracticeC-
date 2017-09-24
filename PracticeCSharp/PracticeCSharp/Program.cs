using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public interface IAnimal
    {
        void Voice();
    }

    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("voice");
        }

        public void Jump()
        {

            Console.WriteLine("Jump");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int[,,] threeDim = {
                {{1,2}}, {{3,4}},
                {{5,6}}, {{7,8}}

            };
            for (int i = 0; i < threeDim.GetLength(0); i++)
            {
                for (int j = 0; j < threeDim.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDim.GetLength(2); k++)
                    {
                        Console.Write(threeDim[i, j, k] + ",");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Length- {threeDim.Length}");
            Console.ReadKey();

        }



    }
}




