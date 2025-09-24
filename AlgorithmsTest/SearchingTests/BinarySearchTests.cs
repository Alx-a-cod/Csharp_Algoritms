using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Searching;
using Xunit;

// ======================================================
// What to Test:
//
// Target present at beginning of array → returns index 0.
// Target present at end of array → returns last index.
// Target present in middle → returns correct index.
// Target not present → returns -1.
// Array with duplicates → returns any valid index of target.
// Array with all same values → returns index if matches, -1 if not.
// Empty array → returns -1.
// Single element array → returns 0 if matches, -1 if not.
// Array with negative and positive numbers → finds correctly.
// Array with zeros → finds correctly among other numbers.
// ======================================================

namespace AlgorithmsLibrary.Searching
{
    public class BinarySearchTests
    {
        [Fact]
        public void TargetAtBeginning_ReturnsIndexZero()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int idx = BinarySearch.Search(arr, 1);
            Assert.Equal(0, idx);
        }

        [Fact]
        public void TargetAtEnd_ReturnsLastIndex()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int idx = BinarySearch.Search(arr, 5);
            Assert.Equal(4, idx);
        }

        [Fact]
        public void TargetInMiddle_ReturnsCorrectIndex()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int idx = BinarySearch.Search(arr, 3);
            Assert.Equal(2, idx);
        }

        [Fact]
        public void TargetNotPresent_ReturnsMinusOne()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int idx = BinarySearch.Search(arr, 6);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void ArrayWithDuplicates_ReturnsAnyValidIndex()
        {
            int[] arr = { 1, 2, 2, 2, 3, 4 };
            int idx = BinarySearch.Search(arr, 2);
            Assert.InRange(idx, 1, 3); // any index of 2 is valid
        }

        [Fact]
        public void ArrayWithAllSameValues_TargetPresent()
        {
            int[] arr = { 7, 7, 7, 7 };
            int idx = BinarySearch.Search(arr, 7);
            Assert.InRange(idx, 0, 3);
        }

        [Fact]
        public void ArrayWithAllSameValues_TargetAbsent()
        {
            int[] arr = { 7, 7, 7, 7 };
            int idx = BinarySearch.Search(arr, 5);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void EmptyArray_ReturnsMinusOne()
        {
            int[] arr = { };
            int idx = BinarySearch.Search(arr, 42);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void SingleElementArray_TargetPresent()
        {
            int[] arr = { 42 };
            int idx = BinarySearch.Search(arr, 42);
            Assert.Equal(0, idx);
        }

        [Fact]
        public void SingleElementArray_TargetAbsent()
        {
            int[] arr = { 42 };
            int idx = BinarySearch.Search(arr, 7);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_FindsCorrectly()
        {
            int[] arr = { -10, -5, 0, 5, 10 };
            int idx = BinarySearch.Search(arr, -5);
            Assert.Equal(1, idx);

            idx = BinarySearch.Search(arr, 10);
            Assert.Equal(4, idx);

            idx = BinarySearch.Search(arr, 0);
            Assert.Equal(2, idx);
        }

        [Fact]
        public void ArrayWithZeros_FindsCorrectly()
        {
            int[] arr = { -2, 0, 0, 1, 3 };
            int idx = BinarySearch.Search(arr, 0);
            Assert.InRange(idx, 1, 2);
        }
    }
}