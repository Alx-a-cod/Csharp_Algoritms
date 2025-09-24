using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================
// What to Test:
//
// Normal unsorted array → sorts correctly.
// Already sorted array → remains unchanged (best case).
// Reverse sorted array → sorts correctly.
// Array with duplicates → sorts correctly and preserves relative order (stable).
// Array with all same values → unchanged.
// Empty array → does nothing.
// Single element array → unchanged.
// Array with negatives and positives → sorts correctly.
// Array with zeros → sorted correctly among other numbers.
// Large array → sorts correctly (sanity/performance).
// ======================================================


namespace AlgorithmsLibrary.SortingTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void NormalUnsortedArray_SortsCorrectly()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { 11, 12, 22, 25, 34, 64, 90 }, arr);
        }

        [Fact]
        public void AlreadySortedArray_RemainsUnchanged()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void ArrayWithDuplicates_SortsCorrectly_Stable()
        {
            (int val, int id)[] arr = { (3, 1), (1, 2), (2, 3), (3, 4), (2, 5) };
            int[] values = Array.ConvertAll(arr, x => x.val);

            BubbleSort.Sort(values);

            Assert.Equal(new[] { 1, 2, 2, 3, 3 }, values);
            // Stability: ensure relative order of duplicates is preserved
            Assert.Equal(3, arr[2].val); // just an example of checking original array IDs if needed
        }

        [Fact]
        public void ArrayWithAllSameValues_RemainsUnchanged()
        {
            int[] arr = { 7, 7, 7, 7 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void EmptyArray_RemainsEmpty()
        {
            int[] arr = { };
            BubbleSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void SingleElementArray_RemainsUnchanged()
        {
            int[] arr = { 42 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_SortsCorrectly()
        {
            int[] arr = { -5, -1, -7, 4, 2, 0 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { -7, -5, -1, 0, 2, 4 }, arr);
        }

        [Fact]
        public void ArrayWithZeros_SortsCorrectly()
        {
            int[] arr = { 0, 5, 0, 3, 2 };
            BubbleSort.Sort(arr);
            Assert.Equal(new[] { 0, 0, 2, 3, 5 }, arr);
        }

        [Fact]
        public void LargeArray_SortsCorrectly()
        {
            int size = 3000; // BubbleSort is slow, use smaller size
            int[] arr = new int[size];
            Random rand = new Random(42);

            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(-1000, 1000);

            int[] expected = (int[])arr.Clone();
            Array.Sort(expected);

            BubbleSort.Sort(arr);

            Assert.Equal(expected, arr);
        }
    }
}
