using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Searching;
using Xunit;

// ======================================================
// Description:      Efficient search for sorted arrays.
//                   Repeatedly divides the search interval in half.
//
// Time complexity:  O(log n).
//
// Space complexity: O(1) iterative, O(log n) recursive.
//
// ======================================================

namespace AlgorithmsLibrary.Searching
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int target)
        {
            int left = 0; // Start of the search interval
            int right = array.Length - 1; // End of the search interval

            while (left <= right) // While the interval is valid
            {
                int mid = left + (right - left) / 2; // Midpoint to avoid overflow

                if (array[mid] == target) // Check if mid is the target
                    return mid; // Found target
                else if (array[mid] < target) // Target is in the right half
                    left = mid + 1; // Search right half
                else
                    right = mid - 1; // Search left half
            }

            return -1; // Not found
        }
    }
}
