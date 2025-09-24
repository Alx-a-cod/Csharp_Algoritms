// ======================================================

// Description:    Divide-and-conquer sorting algorithm.
//                 Splits array into halves, sorts each half, then merges them. 

// Time complexity: O(n log n) average/worst/best.

// Space complexity: O(n) (requires additional space for temporary arrays).

// ======================================================

namespace AlgorithmsLibrary.SortTests

{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array.Length <= 1) // <---- base case: arrays with 0 or 1 element are already sorted
                return;

            int mid = array.Length / 2; // <---- find the midpoint to split the array

            int[] left = new int[mid]; // <---- create left and right subarrays
            int[] right = new int[array.Length - mid]; // <---- right subarray takes the remaining elements

            // Copy data to left and right arrays
            for (int i = 0; i < mid; i++) // <---- copy first half to left array
                left[i] = array[i];

            for (int i = mid; i < array.Length; i++) // <---- copy second half to right array
                right[i - mid] = array[i]; // <---- note the index adjustment for right array

            Sort(left); // <---- recursively sort the left half
            Sort(right); // <---- recursively sort the right half
            Merge(array, left, right); // <---- merge the sorted halves back into the original array
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0; // <---- i for left array, j for right array, k for merged array

            while (i < left.Length && j < right.Length) // <---- merge until one subarray is exhausted
            {
                if (left[i] <= right[j]) // <---- stable sort: use <= to maintain order of equal elements
                    array[k++] = left[i++]; // <---- take element from left array
                else
                    array[k++] = right[j++]; // <---- take element from right array
            }

            while (i < left.Length) // <---- copy any remaining elements from left array
                array[k++] = left[i++]; // <---- note: only one of these two while loops will execute

            while (j < right.Length)    // <---- copy any remaining elements from right array
                array[k++] = right[j++]; // <----as above, only one will execute
        }
    }
}
