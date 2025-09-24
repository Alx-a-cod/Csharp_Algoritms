using AlgorithmsLibrary.Sorting;
using Xunit;
using System;

// ======================================================
// What to Test:
//
// Empty array → should remain empty.
//Single element → should remain unchanged.
//Two elements (already sorted, reverse order, equal).
//Array with duplicates.
//Array already sorted ascending.
//Array sorted descending.
//Array with all equal elements.
//General random array (to check correctness).
//Large array (performance sanity check, not strict performance testing).
//
// ======================================================

namespace AlgorithmsTest.Sorting
{
    public class HeapSortTests
    {
        [Fact]
        public void Sort_EmptyArray_ReturnsEmpty()
        {
            int[] array = Array.Empty<int>();

            HeapSort.Sort(array);

            Assert.Empty(array);
        }

        [Fact]
        public void Sort_SingleElementArray_RemainsUnchanged()
        {
            int[] array = { 42 };

            HeapSort.Sort(array);

            Assert.Equal(new[] { 42 }, array);
        }

        [Theory]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })] // already sorted
        [InlineData(new[] { 2, 1 }, new[] { 1, 2 })] // reverse order
        [InlineData(new[] { 5, 5 }, new[] { 5, 5 })] // equal elements
        public void Sort_TwoElementsArray_SortsCorrectly(int[] input, int[] expected)
        {
            HeapSort.Sort(input);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void Sort_ArrayWithDuplicates_SortsCorrectly()
        {
            int[] array = { 4, 2, 5, 2, 3, 4, 1 };
            int[] expected = { 1, 2, 2, 3, 4, 4, 5 };

            HeapSort.Sort(array);

            Assert.Equal(expected, array);
        }

        [Fact]
        public void Sort_AlreadySortedArray_RemainsSorted()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            HeapSort.Sort(array);

            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7 }, array);
        }

        [Fact]
        public void Sort_DescendingArray_SortsAscending()
        {
            int[] array = { 9, 8, 7, 6, 5, 4, 3 };

            HeapSort.Sort(array);

            Assert.Equal(new[] { 3, 4, 5, 6, 7, 8, 9 }, array);
        }

        [Fact]
        public void Sort_AllEqualElementsArray_RemainsSame()
        {
            int[] array = { 5, 5, 5, 5, 5 };

            HeapSort.Sort(array);

            Assert.Equal(new[] { 5, 5, 5, 5, 5 }, array);
        }

        [Fact]
        public void Sort_RandomArray_SortsCorrectly()
        {
            int[] array = { 10, -1, 3, 5, 2, 0, 8 };
            int[] expected = { -1, 0, 2, 3, 5, 8, 10 };

            HeapSort.Sort(array);

            Assert.Equal(expected, array);
        }

        [Fact]
        public void Sort_LargeArray_SortsCorrectly()
        {
            int size = 1000;
            var random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = random.Next(-1000, 1000);

            int[] expected = (int[])array.Clone();
            Array.Sort(expected); // built-in reference sort

            HeapSort.Sort(array);

            Assert.Equal(expected, array);
        }
    }
}
