using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;

// ======================================================
// What to Test:
//
// Normal unsorted array → sorts correctly.
// Already sorted array → remains unchanged (best case).
// Reverse sorted array → sorts correctly (worst case).
// Array with duplicates → keeps duplicates in sorted order.
// Array with all same values → unchanged.
// Empty array → does nothing (remains empty).
// Single element array → does nothing.
// Array with negatives and positives → sorts correctly.
// Array with zeros → correctly placed with negatives and positives.
// Very large array (sanity check, performance).
// ======================================================

namespace AlgorithmsLibrary.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void NormalUnsortedArray_SortsCorrectly()
        {
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 5, 5, 6, 9 }, arr);
        }

        [Fact]
        public void AlreadySortedArray_RemainsUnchanged()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 9, 7, 5, 3, 1 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { 1, 3, 5, 7, 9 }, arr);
        }

        [Fact]
        public void ArrayWithDuplicates_SortsCorrectly()
        {
            int[] arr = { 4, 2, 5, 2, 3, 5, 1 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 2, 3, 4, 5, 5 }, arr);
        }

        [Fact]
        public void ArrayWithAllSameValues_RemainsUnchanged()
        {
            int[] arr = { 7, 7, 7, 7 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void EmptyArray_RemainsEmpty()
        {
            int[] arr = { };
            InsertionSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void SingleElementArray_RemainsUnchanged()
        {
            int[] arr = { 42 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_SortsCorrectly()
        {
            int[] arr = { -3, -1, -7, 4, 2, 0 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { -7, -3, -1, 0, 2, 4 }, arr);
        }

        [Fact]
        public void ArrayWithZeros_SortsCorrectly()
        {
            int[] arr = { 0, 5, -2, 0, 3 };
            InsertionSort.Sort(arr);
            Assert.Equal(new[] { -2, 0, 0, 3, 5 }, arr);
        }

        [Fact]
        public void LargeArray_SortsCorrectly()
        {
            int size = 1000;
            int[] arr = new int[size];
            Random rand = new Random(42);

            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(-1000, 1000);

            int[] expected = (int[])arr.Clone();
            Array.Sort(expected);

            InsertionSort.Sort(arr);

            Assert.Equal(expected, arr);
        }
    }
}
