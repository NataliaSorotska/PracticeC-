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
            
            program.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadKey();
        }

        Random _pivotRng = new Random();

        public void Sort(int[] items)
        {
            Quicksort(items, 0, items.Length - 1);
        }

        private void Quicksort(int[] items, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);
                int newPivot = Partition(items, left, right, pivotIndex);

                Quicksort(items, left, newPivot - 1);
                Quicksort(items, newPivot + 1, right);
            }
        }

        private int Partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }
        void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
    }
}




