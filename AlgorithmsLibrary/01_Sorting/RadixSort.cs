// ======================================================
//
// Description:      Non - comparison sort for integers or strings of fixed length.
//                   Sorts numbers digit by digit, starting from least significant digit (LSD).
//                   Uses a stable sorting algorithm (like Counting Sort) as a subroutine.
//
// Time complexity:  O(nk) for n numbers with k digits.
//
//Space complexity:  O(n + k).
//
// ======================================================

namespace AlgorithmsLibrary.SortTests
{
    public static class RadixSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length; // <---- get the size of the array
            if (n == 0) return;

            // Find the maximum number to know number of digits
            int max = array[0]; // <---- assume first element is the max
            for (int i = 1; i < n; i++) // <---- iterate through the array to find the true maximum
                if (array[i] > max) max = array[i]; // <---- find the maximum value in the array

            // Do counting sort for each digit
            for (int exp = 1; max / exp > 0; exp *= 10) // <---- exp is 10^i where i is the current digit index (1, 10, 100, ...)
                CountingSortByDigit(array, exp); // <---- sort array based on the digit represented by exp
        }

        private static void CountingSortByDigit(int[] array, int exp)
        {
            int n = array.Length; // <---- get the size of the array
            int[] output = new int[n]; // output array that will hold the sorted order
            int[] count = new int[10]; // digits 0-9

            // Store count of occurrences for each digit
            for (int i = 0; i < n; i++) // <---- count occurrences of each digit in the current exp place
                count[array[i] / exp % 10]++; // <---- extract the digit at exp place and increment its count

            // Convert count[i] to positions
            for (int i = 1; i < 10; i++) // <---- modify count array to hold actual positions of digits in output array
                count[i] += count[i - 1]; // <---- cumulative count

            // Build output array
            for (int i = n - 1; i >= 0; i--) // <---- stable sort: iterate from end to start
            {
                int digit = array[i] / exp % 10; // <---- extract the digit at exp place
                output[count[digit] - 1] = array[i]; // <---- place the element in its correct position in output array
                count[digit]--; // <---- decrement count for that digit
            }

            // Copy output back to array
            for (int i = 0; i < n; i++) // <---- copy sorted output back to original array
                array[i] = output[i]; // <---- array now contains sorted order based on current digit
        }
    }
}
