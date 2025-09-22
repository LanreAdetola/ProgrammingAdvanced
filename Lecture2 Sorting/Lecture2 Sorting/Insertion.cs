using System;

namespace MySorting
{
    public class Insertion
    {
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key; // Insert the key at its correct position
            }
        }
    public void PrintArray(int[] array)
        {
            foreach (int num in array)
            
                Console.Write(num + " ");
            
            Console.WriteLine();
        }
    }
}