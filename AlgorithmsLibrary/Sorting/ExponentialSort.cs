using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================
// Description:      Efficient for unbounded or very large sorted arrays.
//                   Combines exponential search to find range + binary search within that range.
// Time complexity:  O(log n)
//
// Space complexity: O(1)
//
// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class ExponentialSearch
    {
        public static int Search(int[] array, int target) 
        {
            if (array.Length == 0) return -1;  // <---- Handle empty array

            if (array[0] == target) return 0; // <---- Check first element

            int i = 1; // <---- Start with the second element
            while (i < array.Length && array[i] <= target) // <---- Exponentially find range where target could be
                i *= 2; // <---- Double the index

            int left = i / 2; // <---- Left bound of the range
            int right = Math.Min(i, array.Length - 1); // <---- Right bound of the range

            // Use binary search in found range
            return BinarySearch(array, target, left, right); // <---- Call to binary search helper method
        }

        private static int BinarySearch(int[] array, int target, int left, int right)
        {
            while (left <= right) // <---- Standard binary search within the specified bounds
            {
                int mid = left + (right - left) / 2; // <---- Calculate mid to avoid overflow
                if (array[mid] == target) return mid; // <---- Found target
                else if (array[mid] < target) left = mid + 1; // <---- Search right half
                else right = mid - 1; // <---- Search left half
            }
            return -1; // <---- Not found
        }
    }
}
