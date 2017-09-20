using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Program
    {


        static void Main(string[] args)
        {
            Program program = new Program();
            int[] array = new[] { 1, 8, 5, 3, 9 };

            //int count = 0;
            //int left;
            //int right;

            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    left = array[i];
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        count++;
            //        right = array[j];
            //        if (right > left)
            //        {
            //            program.Swap(array, i, j);
            //        }
            //    }

            //}


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]} ");
            //}

            //Console.WriteLine();
            //Console.Write($"count {count}");

            program.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }

        void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                //    //int temp = items[left];
                //    items[left] = items[right];
                //    items[right] = temp;
                items[right] ^= items[left];
                items[left] = items[left] ^ items[right];
                items[right] = items[right] ^ items[left];
            }
        }
        public void Sort(int [] items)
        {
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);
                        swapped = true;
                    }
                }
            } while (swapped != false);
        }
    }
}




