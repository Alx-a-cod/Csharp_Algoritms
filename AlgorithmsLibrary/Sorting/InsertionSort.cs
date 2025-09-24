using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================

//Description:      Builds the sorted array one element at a time, inserting the next element into its correct position.
//                  Very efficient for small arrays or nearly sorted data.

//Time complexity:  O(n²) worst, O(n) best.

//Space complexity: O(1)(in -place). 

// ====================================================== 

namespace AlgorithmsLibrary.Sorting
{
    public static class InsertionSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length; // <---- get the size of the array

            for (int i = 1; i < n; i++) // <---- start from i = 1 because first element is trivially “sorted”.
            {
                int key = array[i]; // <---- current element to be inserted into the sorted portion.
                int j = i - 1; // <---- index of last element in the sorted portion.

                // Move elements greater than key one position ahead
                while (j >= 0 && array[j] > key) // <---- shift elements of sorted portion that are greater than key to the right.
                {
                    array[j + 1] = array[j]; // <---- shift element to the right
                    j--; // <---- move to the previous element in the sorted portion.
                }

                array[j + 1] = key; // place key at correct position
            }
        }
    }
}
