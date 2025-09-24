using AlgorithmsLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ======================================================
// What to Test:
//
// Normal unsorted array → sorts correctly.
// Already sorted array → sorts correctly (worst case for pivot = last element).
// Reverse sorted array → sorts correctly.
// Array with duplicates → sorts correctly (not stable).
// Array with all same values → unchanged.
// Empty array → does nothing.
// Single element array → unchanged.
// Array with negatives and positives → sorts correctly.
// Array with zeros → sorted correctly with negatives/positives.
// Large array → sorts correctly (performance/sanity).
// ======================================================

namespace AlgorithmsLibrary.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void NormalUnsortedArray_SortsCorrectly()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { 1, 5, 7, 8, 9, 10 }, arr);
        }

        [Fact]
        public void AlreadySortedArray_SortsCorrectly()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 9, 7, 5, 3, 1 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { 1, 3, 5, 7, 9 }, arr);
        }

        [Fact]
        public void ArrayWithDuplicates_SortsCorrectly()
        {
            int[] arr = { 4, 2, 5, 2, 3, 5, 1 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 2, 3, 4, 5, 5 }, arr);
        }

        [Fact]
        public void ArrayWithAllSameValues_RemainsUnchanged()
        {
            int[] arr = { 7, 7, 7, 7 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void EmptyArray_RemainsEmpty()
        {
            int[] arr = { };
            QuickSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void SingleElementArray_RemainsUnchanged()
        {
            int[] arr = { 42 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_SortsCorrectly()
        {
            int[] arr = { -3, -1, -7, 4, 2, 0 };
            QuickSort.Sort(arr);
            Assert.Equal(new[] { -7, -3, -1, 0, 2, 4 }, arr);
        }

        [Fact]
        public void ArrayWithZeros_SortsCorrectly()
        {
            int[] arr = { 0, 5, -2, 0, 3 };
            QuickSort.Sort(arr);
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

            QuickSort.Sort(arr);

            Assert.Equal(expected, arr);
        }
    }
}