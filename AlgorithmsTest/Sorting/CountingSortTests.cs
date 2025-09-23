using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using MathNet.Numerics.Distributions;
using Xunit;

// ======================================================
// What to Test:
//
// Normal unsorted array → sorts correctly.
//Already sorted array → remains unchanged.
//Reverse sorted array → sorts correctly.
//Array with duplicates → preserves correct counts.
//Array with all same values → stays same.
//Empty array → does nothing.
//Single element array → does nothing.
//Array with 0 values → checks lower bound.
//
// ======================================================

//we don't have negatives, so thankfully we don't need to test that case

namespace AlgorithmsTest.Sorting
{
    public class CountingSortTests
    {
        [Fact]
        public void Sort_UnsortedArray_SortsCorrectly()
        {
            int[] arr = { 5, 2, 9, 1, 5, 3 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 1, 2, 3, 5, 5, 9 }, arr);
        }

        [Fact]
        public void Sort_AlreadySortedArray_NoChange()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void Sort_ReverseSortedArray_SortsCorrectly()
        {
            int[] arr = { 9, 7, 5, 3, 1 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 1, 3, 5, 7, 9 }, arr);
        }

        [Fact]
        public void Sort_ArrayWithDuplicates_SortsCorrectly()
        {
            int[] arr = { 4, 2, 4, 2, 1 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 1, 2, 2, 4, 4 }, arr);
        }

        [Fact]
        public void Sort_AllSameValues_NoChange()
        {
            int[] arr = { 7, 7, 7, 7 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 7, 7, 7, 7 }, arr);
        }

        [Fact]
        public void Sort_EmptyArray_NoChange()
        {
            int[] arr = { };
            CountingSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void Sort_SingleElement_NoChange()
        {
            int[] arr = { 42 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 42 }, arr);
        }

        [Fact]
        public void Sort_ArrayWithZeroValues_SortsCorrectly()
        {
            int[] arr = { 0, 5, 2, 0, 1 };
            CountingSort.Sort(arr);
            Assert.Equal(new int[] { 0, 0, 1, 2, 5 }, arr);
        }
    }
}
