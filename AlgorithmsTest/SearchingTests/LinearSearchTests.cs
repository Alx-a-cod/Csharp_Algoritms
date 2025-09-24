using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Searching;
// ======================================================
// What to Test:
//
// Target at beginning → returns index 0.
// Target at end → returns last index.
// Target in middle → returns correct index.
// Target not present → returns -1.
// Array with duplicates → returns first occurrence index.
// Array with all same values → returns index if matches, -1 if not.
// Empty array → returns -1.
// Single element array → returns 0 if matches, -1 if not.
// Array with negative and positive numbers → finds correctly.
// Array with zeros → finds correctly among other numbers.
// ======================================================

namespace AlgorithmsTest.SearchingTests
{
    public class LinearSearchTests
    {
        [Fact]
        public void TargetAtBeginning_ReturnsIndexZero()
        {
            int[] arr = { 10, 20, 30, 40 };
            int idx = LinearSearch.Search(arr, 10);
            Assert.Equal(0, idx);
        }

        [Fact]
        public void TargetAtEnd_ReturnsLastIndex()
        {
            int[] arr = { 10, 20, 30, 40 };
            int idx = LinearSearch.Search(arr, 40);
            Assert.Equal(3, idx);
        }

        [Fact]
        public void TargetInMiddle_ReturnsCorrectIndex()
        {
            int[] arr = { 10, 20, 30, 40 };
            int idx = LinearSearch.Search(arr, 30);
            Assert.Equal(2, idx);
        }

        [Fact]
        public void TargetNotPresent_ReturnsMinusOne()
        {
            int[] arr = { 10, 20, 30, 40 };
            int idx = LinearSearch.Search(arr, 50);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void ArrayWithDuplicates_ReturnsFirstOccurrence()
        {
            int[] arr = { 1, 2, 3, 2, 4 };
            int idx = LinearSearch.Search(arr, 2);
            Assert.Equal(1, idx); // first occurrence
        }

        [Fact]
        public void ArrayWithAllSameValues_TargetPresent()
        {
            int[] arr = { 5, 5, 5, 5 };
            int idx = LinearSearch.Search(arr, 5);
            Assert.Equal(0, idx);
        }

        [Fact]
        public void ArrayWithAllSameValues_TargetAbsent()
        {
            int[] arr = { 5, 5, 5, 5 };
            int idx = LinearSearch.Search(arr, 7);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void EmptyArray_ReturnsMinusOne()
        {
            int[] arr = { };
            int idx = LinearSearch.Search(arr, 42);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void SingleElementArray_TargetPresent()
        {
            int[] arr = { 42 };
            int idx = LinearSearch.Search(arr, 42);
            Assert.Equal(0, idx);
        }

        [Fact]
        public void SingleElementArray_TargetAbsent()
        {
            int[] arr = { 42 };
            int idx = LinearSearch.Search(arr, 7);
            Assert.Equal(-1, idx);
        }

        [Fact]
        public void ArrayWithNegativesAndPositives_FindsCorrectly()
        {
            int[] arr = { -3, -1, -7, 4, 2, 0 };
            int idx = LinearSearch.Search(arr, -7);
            Assert.Equal(2, idx);

            idx = LinearSearch.Search(arr, 4);
            Assert.Equal(3, idx);
        }

        [Fact]
        public void ArrayWithZeros_FindsCorrectly()
        {
            int[] arr = { 0, 5, 0, 3, 2 };
            int idx = LinearSearch.Search(arr, 0);
            Assert.Equal(0, idx); // first occurrence
        }
    }

}
