// Program.cs
using System;

namespace MyBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 4, 2 };

            Sort sorter = new Sort(); // Create object of Sort class

            Console.WriteLine("Before sorting:");
            sorter.PrintArray(numbers);

            sorter.BubbleSort(numbers); // Call the sorting method

            Console.WriteLine("\nAfter sorting:");
            sorter.PrintArray(numbers);
        }
    }
}
