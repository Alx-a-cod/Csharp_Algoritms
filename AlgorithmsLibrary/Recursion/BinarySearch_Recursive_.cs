using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// =================================================================
// Description:      It searches for a target value within a sorted array and returns the index of the target if found, or -1 if not found.
//                   The search is performed using a recursive binary search algorithm.
//                   Base case: If the left index exceeds the right index, the target is not found, and -1 is returned.
//                   Recursive case: Calculate the midpoint and compare the middle element with the target.
//
// Time Complexity:  O(log n) - Each recursive call halves the search space.
// Space Complexity: O(log n) - Due to the recursion stack.
//------------------------------------------------------------------
// Example:        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//                 int target = 5;
//                int result = BinarySearchRecursive.Search(array, target);
//                // result will be 4 (the index of the target in the array)
//=================================================================


namespace AlgorithmsLibrary.Recursion
{
    public static class BinarySearchRecursive
    {
        public static int Search(int[] array, int target) // <---- Public method to initiate the search
        {
            return Search(array, target, 0, array.Length - 1); // <---- Calls the private recursive method with initial bounds
        }

        private static int Search(int[] array, int target, int left, int right) // <---- Private recursive method that performs the actual search
        {
            if (left > right) return -1; // Base case: not found

            int mid = left + (right - left) / 2; //<---- Midpoint to avoid overflow

            if (array[mid] == target) return mid; // <---- Found target
            if (array[mid] < target) return Search(array, target, mid + 1, right); // <---- Search right half
            return Search(array, target, left, mid - 1); // <---- Search left half
        }
    }
}
