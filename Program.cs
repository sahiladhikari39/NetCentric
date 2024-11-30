using System;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Unsorted array:");
            BubbleSort sorter = new BubbleSort();
            sorter.PrintArray(array);

            sorter.Sort(array);

            Console.WriteLine("Sorted array:");
            sorter.PrintArray(array);
        }
    }
}
