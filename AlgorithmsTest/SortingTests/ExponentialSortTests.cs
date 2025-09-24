using AlgorithmsLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ======================================================
// What to Test:
//
// Normal unsorted array  → (Not applicable, array must be sorted)
// Sorted array with target present → returns correct index.
// Sorted array with target absent  → returns -1.
// Already sorted ascending array  → still works fine.
// Reverse sorted array  → (Not valid input, must assert/test undefined behavior).
// Array with duplicates → returns index of one occurrence (not necessarily first).
// Array with all same values (equal to target) → returns valid index.
// Array with all same values (not equal to target) → returns -1.
// Empty array → returns -1.
// Single element array (target present) → returns 0.
// Single element array (target absent) → returns -1.
// Target is first element → index 0.
// Target is last element  → index == array.Length - 1.
// Target less than minimum → returns -1.
// Target greater than maximum → returns -1.
// Large array (performance sanity check) → still correct.
// ======================================================


namespace AlgorithmsLibrary.Tests
    {
        public class ExponentialSearchTests
        {
            [Fact]
            public void SortedArray_TargetPresent_ReturnsCorrectIndex()
            {
                int[] arr = { 1, 3, 5, 7, 9, 11 };
                int result = ExponentialSearch.Search(arr, 7);
                Assert.Equal(3, result);
            }

            [Fact]
            public void SortedArray_TargetAbsent_ReturnsMinusOne()
            {
                int[] arr = { 2, 4, 6, 8, 10 };
                int result = ExponentialSearch.Search(arr, 5);
                Assert.Equal(-1, result);
            }

            [Fact]
            public void EmptyArray_ReturnsMinusOne()
            {
                int[] arr = { };
                int result = ExponentialSearch.Search(arr, 42);
                Assert.Equal(-1, result);
            }

            [Fact]
            public void SingleElementArray_TargetPresent_ReturnsZero()
            {
                int[] arr = { 99 };
                int result = ExponentialSearch.Search(arr, 99);
                Assert.Equal(0, result);
            }

            [Fact]
            public void SingleElementArray_TargetAbsent_ReturnsMinusOne()
            {
                int[] arr = { 99 };
                int result = ExponentialSearch.Search(arr, 100);
                Assert.Equal(-1, result);
            }

            [Fact]
            public void TargetIsFirstElement_ReturnsZero()
            {
                int[] arr = { 5, 10, 15, 20 };
                int result = ExponentialSearch.Search(arr, 5);
                Assert.Equal(0, result);
            }

            [Fact]
            public void TargetIsLastElement_ReturnsLastIndex()
            {
                int[] arr = { 2, 4, 6, 8, 10 };
                int result = ExponentialSearch.Search(arr, 10);
                Assert.Equal(arr.Length - 1, result);
            }

            [Fact]
            public void TargetLessThanMinimum_ReturnsMinusOne()
            {
                int[] arr = { 3, 6, 9, 12 };
                int result = ExponentialSearch.Search(arr, 1);
                Assert.Equal(-1, result);
            }

            [Fact]
            public void TargetGreaterThanMaximum_ReturnsMinusOne()
            {
                int[] arr = { 3, 6, 9, 12 };
                int result = ExponentialSearch.Search(arr, 20);
                Assert.Equal(-1, result);
            }

            [Fact]
            public void ArrayWithDuplicates_ReturnsAnyValidIndex()
            {
                int[] arr = { 1, 2, 4, 4, 4, 7, 9 };
                int result = ExponentialSearch.Search(arr, 4);
                Assert.True(result >= 2 && result <= 4);
            }

            [Fact]
            public void ArrayAllSameValues_TargetPresent_ReturnsValidIndex()
            {
                int[] arr = { 5, 5, 5, 5, 5 };
                int result = ExponentialSearch.Search(arr, 5);
                Assert.InRange(result, 0, arr.Length - 1);
            }

            [Fact]
            public void ArrayAllSameValues_TargetAbsent_ReturnsMinusOne()
            {
                int[] arr = { 5, 5, 5, 5, 5 };
                int result = ExponentialSearch.Search(arr, 10);
                Assert.Equal(-1, result);
            }

            [Fact]
            public void LargeArray_TargetPresent_WorksCorrectly()
            {
                int[] arr = new int[100000];
                for (int i = 0; i < arr.Length; i++) arr[i] = i;

                int target = 98765;
                Array.Resize(ref arr, 1000000); // make it huge with trailing zeros
                for (int i = 100000; i < arr.Length; i++) arr[i] = i;

                int result = ExponentialSearch.Search(arr, target);
                Assert.Equal(target, result);
            }
        }
    }