using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;
using Xunit;

// ======================================================
// What to Test:
//
// Normal array → returns correct sum.
// Array with negative numbers → sums correctly.
// Array with all zeros → sum is zero.
// Single element array → sum equals that element.
// Empty array → sum is zero.
// Null array → throws ArgumentNullException.
// Large array → sums correctly (sanity/performance).
// ======================================================

namespace AlgorithmsTest.RecursionTests
{
    public class ArraySumTests
    {
        [Fact]
        public void NormalArray_ReturnsCorrectSum()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = ArraySum.Compute(arr);
            Assert.Equal(15, sum);
        }

        [Fact]
        public void ArrayWithNegativeNumbers_SumsCorrectly()
        {
            int[] arr = { -1, 2, -3, 4 };
            int sum = ArraySum.Compute(arr);
            Assert.Equal(2, sum);
        }

        [Fact]
        public void ArrayWithAllZeros_SumIsZero()
        {
            int[] arr = { 0, 0, 0, 0 };
            int sum = ArraySum.Compute(arr);
            Assert.Equal(0, sum);
        }

        [Fact]
        public void SingleElementArray_ReturnsElementValue()
        {
            int[] arr = { 42 };
            int sum = ArraySum.Compute(arr);
            Assert.Equal(42, sum);
        }

        [Fact]
        public void EmptyArray_ReturnsZero()
        {
            int[] arr = { };
            int sum = ArraySum.Compute(arr);
            Assert.Equal(0, sum);
        }

        [Fact]
        public void NullArray_ThrowsArgumentNullException()
        {
            int[]? arr = null;
            Assert.Throws<ArgumentNullException>(() => ArraySum.Compute(arr));
        }

        [Fact]
        public void LargeArray_SumsCorrectly()
        {
            int size = 1000;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) arr[i] = i + 1;

            int expected = (size * (size + 1)) / 2; // sum of first n numbers
            int sum = ArraySum.Compute(arr);

            Assert.Equal(expected, sum);
        }

        [Fact]
        public void PartialArray_SumsCorrectly()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = ArraySum.Compute(arr, 3); // sum first 3 elements
            Assert.Equal(6, sum);
        }
    }
}
