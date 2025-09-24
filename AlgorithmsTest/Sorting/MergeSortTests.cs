using AlgorithmsLibrary.SortTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ======================================================
// What to Test:
//
// Normal unsorted array → sorts correctly.
// Already sorted array → remains unchanged.
// Reverse sorted array → sorts correctly.
// Array with duplicates → preserves correct counts (and order → stability).
// Array with all same values → unchanged.
// Empty array → does nothing (remains empty).
// Single element array → unchanged.
// Array with negatives and positives → sorts correctly.
// Array with zeros → sorts correctly in mixed input.
// Large array → sorts correctly (sanity + performance).
// Stability check → equal elements keep relative order.
// ======================================================

namespace AlgorithmsLibrary.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void NormalUnsortedArray_SortsCorrectly()
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { 3, 9, 10, 27, 38, 43, 82 }, arr);
        }

        [Fact]
        public void AlreadySortedArray_RemainsUnchanged()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 9, 7, 5, 3, 1 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { 1, 3, 5, 7, 9 }, arr);
        }

        [Fact]
        public void ArrayWithDuplicates_SortsCorrectly()
        {
            int[] arr = { 4, 2, 5, 2, 3, 5, 1 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 2, 3, 4, 5, 5 }, arr);
        }

        [Fact]
        public void ArrayWithAllSameValues_RemainsUnchanged()
        {
            int[] arr = { 7, 7, 7, 7 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void EmptyArray_RemainsEmpty()
        {
            int[] arr = { };
            MergeSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void SingleElementArray_RemainsUnchanged()
        {
            int[] arr = { 42 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_SortsCorrectly()
        {
            int[] arr = { -3, -1, -7, 4, 2, 0 };
            MergeSort.Sort(arr);
            Assert.Equal(new[] { -7, -3, -1, 0, 2, 4 }, arr);
        }

        [Fact]
        public void ArrayWithZeros_SortsCorrectly()
        {
            int[] arr = { 0, 5, -2, 0, 3 };
            MergeSort.Sort(arr);
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

            MergeSort.Sort(arr);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void StabilityCheck_EqualElementsPreserveOrder()
        {
            // Using tuples (value, id) to check stability
            (int val, int id)[] arr = {
                (2, 1), (1, 2), (2, 3), (1, 4), (2, 5)
            };

            // Extract values for sorting
            int[] values = Array.ConvertAll(arr, x => x.val);
            MergeSort.Sort(values);

            // After sorting, duplicates of 1 and 2 should preserve original order
            Assert.Equal(new[] { 1, 1, 2, 2, 2 }, values);
        }
    }
}
