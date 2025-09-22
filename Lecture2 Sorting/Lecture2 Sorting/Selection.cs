using System;

namespace MySorting
{

  public class Selection
  {
    public void Sort(int[] array)

      { int n = array.Length;

        for (int i = 0; i < n - 1; i++)

        { int minIndex = i;

          for (int j = i + 1; j < n; j++)

          { 
            if (array[j] < array[minIndex])
            {
              minIndex = j;
            }
          }

          // to swap
          int temp = array[minIndex];
          array[minIndex] = array[i];
          array[i] = temp;
        }
      }
  


// Utility method to print the array
        public void PrintArray(int[] array)
        {
            foreach (int num in array)
            
                Console.Write(num + " ");
            
            Console.WriteLine();
        }
    }
}