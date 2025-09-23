// ======================================================
//
// Description:      Divide and conquer using a “pivot” element.
//                   Partitions array into elements smaller/larger than pivot, then recursively sorts partitions.
//
// Average time:     O(n log n), Worst: O(n²) (rare with good pivot choice).
//
// Space complexity: O(log n) due to recursion.
//
// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class QuickSort
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1); // initial call with full array range
        }

        private static void Sort(int[] array, int low, int high)
        {
            if (low < high) // <----  base case: if the partition has more than one element
            {
                int pivotIndex = Partition(array, low, high); // <---- partitioning step
                Sort(array, low, pivotIndex - 1); // <---- recursively sort left partition
                Sort(array, pivotIndex + 1, high); // <---- recursively sort right partition
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high]; // <---- choose the last element as pivot
            int i = low - 1; // <---- pointer for the smaller element

            for (int j = low; j < high; j++) // <---- iterate through all elements
            {
                if (array[j] <= pivot) // <---- if current element is smaller than or equal to pivot
                {
                    i++; // <---- increment pointer for smaller element

                    // swap array[i] and array[j]
                    int temp = array[i]; // <---- swap elements to place smaller element before the pivot
                    array[i] = array[j]; // <---- array[i] = array[j];
                    array[j] = temp; // <---- place the smaller element at its correct position
                }
            }

            // swap pivot into correct position
            int tempPivot = array[i + 1]; // <---- place pivot in its correct position
            array[i + 1] = array[high]; // <---- array[high] is the pivot
            array[high] = tempPivot; // <---- swap

            return i + 1; // return pivot index
        }
    }
}
