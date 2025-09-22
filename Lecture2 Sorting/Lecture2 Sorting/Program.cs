// Program.cs
using System;
using MySorting;

namespace MySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 5, 3, 8, 4, 2 };
            int[] numbers2 = { 5, 3, 8, 4, 2 };
            int[] numbers3 = { 5, 3, 8, 4, 2 };
            

            // Bubble Sort
            Bubble bubble = new Bubble(); // Create object of Sort class

            Console.WriteLine("Before Bubble sorting:");
            bubble.PrintArray(numbers1);

            bubble.Sort(numbers1); // Call the sorting method

            Console.WriteLine("\nAfter sorting:");
            bubble.PrintArray(numbers1);


            // Selection Sort
            Selection selection = new Selection(); // Create object of Selection class 

            Console.WriteLine("\nBefore Selection sorting:");
            selection.PrintArray(numbers2);

            selection.Sort(numbers2); // Call the sorting method
            
            Console.WriteLine("\nAfter Selection sorting:");
            selection.PrintArray(numbers2);

            // Insertion Sort
            Insertion insertion = new Insertion(); // Create object of Insertion class

            Console.WriteLine("\nBefore Insertion sorting:");
            insertion.PrintArray(numbers3);

            insertion.Sort(numbers3); // Call the sorting method

            Console.WriteLine("\nAfter Insertion sorting:");
            insertion.PrintArray(numbers3);


        }
    }
}


