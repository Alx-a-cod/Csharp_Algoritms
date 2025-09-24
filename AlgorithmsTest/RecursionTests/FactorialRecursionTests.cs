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
// n = 0 → returns 1 (base case).
// n = 1 → returns 1.
// Small positive numbers → returns correct factorial.
// Larger positive numbers → returns correct factorial.
// Negative numbers → throws ArgumentException.
// Edge case: maximum n before integer overflow → optional sanity check.
// ======================================================

namespace AlgorithmsTest.RecursionTests
{
    public class FactorialRecursionTests
    {
        [Fact]
        public void Zero_ReturnsOne()
        {
            int result = FactorialRecursion.Compute(0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void One_ReturnsOne()
        {
            int result = FactorialRecursion.Compute(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SmallPositiveNumber_ReturnsCorrectFactorial()
        {
            int result = FactorialRecursion.Compute(5);
            Assert.Equal(120, result); // 5! = 120
        }

        [Fact]
        public void AnotherSmallPositiveNumber_ReturnsCorrectFactorial()
        {
            int result = FactorialRecursion.Compute(7);
            Assert.Equal(5040, result); // 7! = 5040
        }

        [Fact]
        public void NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FactorialRecursion.Compute(-3));
        }

        [Fact]
        public void LargeNumber_SanityCheck()
        {
            // Note: 12! = 479001600, 13! exceeds int.MaxValue
            int result = FactorialRecursion.Compute(12);
            Assert.Equal(479001600, result);
        }
    }
}
