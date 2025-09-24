using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Searching;
using Xunit;

// ======================================================
// Description:      Similar to binary search but splits array into three parts.
//                   Rarely used in practice but very cool academically speaking. It's a rule of THIRDS!:D.
//                   Works only on sorted arrays.
//
// Time complexity:  O(log₃ n)
//
// Space complexity: O(1) iterative, O(log n) recursive.
//
// ======================================================

namespace AlgorithmsLibrary.Searching
{
    public static class TernarySearch
    {
        public static int Search(int[] array, int target) // <---- public method to initiate the search
        {
            return Search(array, target, 0, array.Length - 1); // <---- calls the private recursive method with initial bounds. RECURSIONS, YAY!
        }

        private static int Search(int[] array, int target, int left, int right) // <---- private recursive method that performs the actual search
        {
            if (left > right) // Base case: target not found
                return -1; // <---- target not found, and stops

            int third = (right - left) / 3; // <---- calculate one third of the current segment
            int mid1 = left + third; // <---- first mid point
            int mid2 = right - third; // <---- second mid point

            if (array[mid1] == target) // <---- check if target is at mid1
                return mid1; // Found target at mid1
            if (array[mid2] == target) // <---- check if target is at mid2
                return mid2; // Found target at mid2

            if (target < array[mid1]) // <---- target is in the left third
                return Search(array, target, left, mid1 - 1); // Search left third
            else if (target > array[mid2]) // <---- target is in the right third
                return Search(array, target, mid2 + 1, right); // Search right third
            else // <---- target is in the middle third
                return Search(array, target, mid1 + 1, mid2 - 1); // Search middle third
        }
    }
}
