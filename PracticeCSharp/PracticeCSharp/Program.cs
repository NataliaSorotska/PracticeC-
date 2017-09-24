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
            int[] array = {1, 2, 3, 4, 5};
            array = new[] {5};
            array=new int[5] {1,2,3,4,5};
            array = new[] {1, 2, 3, 4, 5};
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();

        }



    }
}




