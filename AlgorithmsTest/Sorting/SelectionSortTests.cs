using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.SortTests;

// ======================================================
// What to Test:
//
// Normal unsorted array → sorts correctly.
// Already sorted array → remains unchanged.
// Reverse sorted array → sorts correctly.
// Array with duplicates → sorts correctly (not stable).
// Array with all same values → unchanged.
// Empty array → does nothing.
// Single element array → unchanged.
// Array with negatives and positives → sorts correctly.
// Array with zeros → sorted correctly with negatives/positives.
// Large array → sorts correctly (sanity/performance).
// ======================================================

// NOTE: Selection Sort is not a stable sort, so stability checks are not included.

namespace AlgorithmsLibrary.Tests
{
    public class SelectionSortTests
    {
        [Fact]
        public void NormalUnsortedArray_SortsCorrectly()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { 11, 12, 22, 25, 64 }, arr);
        }

        [Fact]
        public void AlreadySortedArray_RemainsUnchanged()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 9, 7, 5, 3, 1 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { 1, 3, 5, 7, 9 }, arr);
        }

        [Fact]
        public void ArrayWithDuplicates_SortsCorrectly()
        {
            int[] arr = { 5, 3, 5, 2, 8, 3, 1 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 3, 5, 5, 8 }, arr);
        }

        [Fact]
        public void ArrayWithAllSameValues_RemainsUnchanged()
        {
            int[] arr = { 7, 7, 7, 7, 7 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { 7, 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void EmptyArray_RemainsEmpty()
        {
            int[] arr = { };
            SelectionSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void SingleElementArray_RemainsUnchanged()
        {
            int[] arr = { 42 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_SortsCorrectly()
        {
            int[] arr = { -3, -1, -7, 4, 2, 0 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { -7, -3, -1, 0, 2, 4 }, arr);
        }

        [Fact]
        public void ArrayWithZeros_SortsCorrectly()
        {
            int[] arr = { 0, 5, -2, 0, 3 };
            SelectionSort.Sort(arr);
            Assert.Equal(new[] { -2, 0, 0, 3, 5 }, arr);
        }

        [Fact]
        public void LargeArray_SortsCorrectly()
        {
            int size = 5000;
            int[] arr = new int[size];
            Random rand = new Random(42);

            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(-10000, 10000);

            int[] expected = (int[])arr.Clone();
            Array.Sort(expected);

            SelectionSort.Sort(arr);

            Assert.Equal(expected, arr);
        }
    }
}