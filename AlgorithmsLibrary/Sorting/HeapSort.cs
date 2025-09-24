using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================
// Description:       Uses a binary heap data structure to sort an array.
//                    Steps:
//                        1. Build a max-heap from the array.
//                        2. Swap the first element (largest) with the last element.
//                        3. Reduce heap size by 1 and heapify the root.
//                        4. Repeat until the heap is empty.
//
// Time complexity:   O(n log n) always.
//
// Space complexity:  O(1)(in -place).
//
// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class HeapSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length; // <---- get the size of the array

            // Build max heap
            for (int i = n / 2 - 1; i >= 0; i--) // <---- start from the last non-leaf node and heapify each node
                Heapify(array, n, i); // <---- build the max heap

            // Extract elements from heap
            for (int i = n - 1; i >= 0; i--) // <---- one by one extract elements from heap
            {
                // Move current root (largest) to end
                int temp = array[0]; // <---- swap the root of the heap (largest element) with the last element of the heap
                array[0] = array[i]; // <---- array[0] = array[i];
                array[i] = temp; // <---- place the largest element at its correct position

                // Call max heapify on reduced heap
                Heapify(array, i, 0); // <---- heapify the root of the tree to maintain the max-heap property
            }
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i; // <---- Initialize largest as root
            int left = 2 * i + 1; // left child index
            int right = 2 * i + 2; // right child index

            // If left child is larger than root
            if (left < n && array[left] > array[largest]) // <---- check if left child exists and is greater than root
                largest = left; // <---- update largest if left child is larger

            // If right child is larger than largest
            if (right < n && array[right] > array[largest]) // <---- check if right child exists and is greater than current largest
                largest = right; // <---- update largest if right child is larger

            // If largest is not root
            if (largest != i) // <---- if largest is not root, swap and continue heapifying
            {
                int swap = array[i]; // <---- swap root with largest
                array[i] = array[largest]; // <---- array[i] = array[largest];
                array[largest] = swap; // <---- place the largest element at root

                // Recursively heapify the affected subtree
                Heapify(array, n, largest); // <---- recursively heapify the affected subtree
            }
        }
    }
}
