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
        public void Sort(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);

                sortedRangeEnd++;
            }
        }

        private int FindIndexOfSmallestFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }
            return currentSmallestIndex;
        }
    }
}




