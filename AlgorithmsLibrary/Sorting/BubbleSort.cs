using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================
// Description:      Simple comparison-based sort.
//                   Repeatedly steps through the array, compares adjacent items, and swaps them if they are in the wrong order.
//                   The process is repeated until the array is sorted.
//
// Time complexity:  O(n²) average/worst, O(n) best (if already sorted).
//
// Space complexity: O(1) (in-place).
//
// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length; // <---- get the size of the array

            // Outer loop: number of passes
            for (int i = 0; i < n - 1; i++) // <---- n-1 passes are needed to guarantee full sort
            {
                // Inner loop: comparing adjacent elements
                for (int j = 0; j < n - i - 1; j++) // <---- compares each adjacent pair, and stops earlier each pass
                                                    // because last i elements are already sorted.
                {
                    if (array[j] > array[j + 1]) // <---- if the current element is greater than the next, check if swaps is needed
                    {
                        // Swap if the current element is greater than next, using temporary variable
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
