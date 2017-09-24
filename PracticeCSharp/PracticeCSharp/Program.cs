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
            Random random =new Random();

            int[,] array= new int[3,3];

            for (int i = 0; i <3;  i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }



    }
}




