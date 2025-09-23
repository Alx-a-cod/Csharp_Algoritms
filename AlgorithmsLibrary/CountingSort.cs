// ======================================================
//
// Description:       Non - comparison sort, works for integers in a known small range.
//                    Counts occurrences of each value, then places them in sorted order.
//                    Stable and very fast for small ranges.
//
// Time complexity:   O(n + k) where k is the range of input.
//
// Space complexity:  O(n + k).
//
// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class CountingSort
    {
        public static void Sort(int[] array) 
        {
            int n = array.Length; // <---- get the size of the array
            if (n == 0) return;

            // Find the maximum value
            int max = array[0]; // <---- assume first element is the max
            for (int i = 1; i < n; i++) // <---- iterate through the array to find the true maximum
                if (array[i] > max) max = array[i]; 

            int[] count = new int[max + 1]; // <---- create count array to store occurrences of each value

            // Count occurrences
            for (int i = 0; i < n; i++)
                count[array[i]]++;

            // Overwrite original array with sorted values
            int index = 0; // <---- index for placing sorted values back into original array
            for (int i = 0; i <= max; i++) // <---- iterate through count array
            {
                while (count[i] > 0) // <---- while there are occurrences of value i
                {
                    array[index++] = i; // <---- place i into the original array
                    count[i]--; // <---- decrement count for value i
                }
            }
        }
    }
}
