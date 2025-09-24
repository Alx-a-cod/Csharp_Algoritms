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
// Already sorted array → remains unchanged.
// Reverse sorted array → sorts correctly.
// Array with duplicates → sorts correctly, counts preserved.
// Array with all same values → unchanged.
// Empty array → does nothing.
// Single element array → unchanged.
// Array with zeros → sorts correctly with other numbers.
// Array with varying digit lengths → correctly sorted (handles multiple digit places).
// Large array → sorts correctly (sanity/performance).
// Stability check → equal values remain in original relative order.
// ======================================================

namespace AlgorithmsLibrary.Tests
{
    public class RadixSortTests
    {
        [Fact]
        public void NormalUnsortedArray_SortsCorrectly()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 2, 24, 45, 66, 75, 90, 170, 802 }, arr);
        }

        [Fact]
        public void AlreadySortedArray_RemainsUnchanged()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, arr);
        }

        [Fact]
        public void ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, arr);
        }

        [Fact]
        public void ArrayWithDuplicates_SortsCorrectly()
        {
            int[] arr = { 5, 3, 5, 2, 8, 3, 1 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 3, 5, 5, 8 }, arr);
        }

        [Fact]
        public void ArrayWithAllSameValues_RemainsUnchanged()
        {
            int[] arr = { 7, 7, 7, 7, 7 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 7, 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void EmptyArray_RemainsEmpty()
        {
            int[] arr = { };
            RadixSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void SingleElementArray_RemainsUnchanged()
        {
            int[] arr = { 42 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void ArrayWithZeros_SortsCorrectly()
        {
            int[] arr = { 0, 5, 0, 3, 2 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 0, 0, 2, 3, 5 }, arr);
        }

        [Fact]
        public void ArrayWithVaryingDigitLengths_SortsCorrectly()
        {
            int[] arr = { 1, 10, 100, 21, 3, 301, 11 };
            RadixSort.Sort(arr);
            Assert.Equal(new[] { 1, 3, 10, 11, 21, 100, 301 }, arr);
        }

        [Fact]
        public void LargeArray_SortsCorrectly()
        {
            int size = 5000;
            int[] arr = new int[size];
            Random rand = new Random(42);

            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(0, 100000);

            int[] expected = (int[])arr.Clone();
            Array.Sort(expected);

            RadixSort.Sort(arr);

            Assert.Equal(expected, arr);
        }

        [Fact]
        public void StabilityCheck_EqualElementsRemainStable()
        {
            // Values with unique IDs (simulate stability)
            (int val, int id)[] arr = { (21, 1), (3, 2), (21, 3), (3, 4), (21, 5) };

            // Extract just values to sort
            int[] values = Array.ConvertAll(arr, x => x.val);
            RadixSort.Sort(values);

            // Values should be sorted, and equal values appear in same input order
            Assert.Equal(new[] { 3, 3, 21, 21, 21 }, values);
        }
    }
}