using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================

// Description :     Simple comparison-based sort.
//                   Selects the minimum (or maximum) element and moves it to the correct position in each iteration.
//                   Simple but not very efficient for large arrays.

//Time complexity:   O(n²) always.

// Space complexity: O(1)(in -place).

// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class SelectionSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length; //<---- get the size of the array

            for (int i = 0; i < n - 1; i++) //<---- n-1 passes are needed to guarantee full sort,
                                            //outer loop iterates over each position where we want to place the correct element.
            {
                int minIndex = i; //<---- initial assumption: first element of unsorted portion is smallest.

                for (int j = i + 1; j < n; j++) //<---- inner loop searches for the true minimum in remaining unsorted elements.
                {
                    if (array[j] < array[minIndex]) // <---- found new minimum
                        minIndex = j; // found new minimum
                }

                // Swap minimum element with first element of unsorted part
                int temp = array[minIndex]; // <---- swap the found minimum element with the first element of the unsorted portion.
                array[minIndex] = array[i]; // <---- array[i] = temp;
                array[i] = temp; // <---- place the minimum at its correct position.
            }
        }
    }
}