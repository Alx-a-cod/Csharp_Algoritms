using AlgorithmsLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ======================================================
// What to Test:
//
// n = 0 → returns 0 (base case).
// n = 1 → returns 1 (base case).
// Small positive numbers → returns correct Fibonacci number.
// Medium positive numbers → returns correct Fibonacci number (sanity check).
// Negative numbers → throws ArgumentException.
// ======================================================

namespace AlgorithmsTest.RecursionTests
{
    public class FibonacciNumbersTests
    {
        [Fact]
        public void Zero_ReturnsZero()
        {
            int result = Fibonacci.Compute(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void One_ReturnsOne()
        {
            int result = Fibonacci.Compute(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SmallPositiveNumbers_ReturnsCorrectFibonacci()
        {
            Assert.Equal(1, Fibonacci.Compute(2));
            Assert.Equal(2, Fibonacci.Compute(3));
            Assert.Equal(3, Fibonacci.Compute(4));
            Assert.Equal(5, Fibonacci.Compute(5));
            Assert.Equal(8, Fibonacci.Compute(6));
            Assert.Equal(13, Fibonacci.Compute(7));
        }

        [Fact]
        public void MediumNumber_SanityCheck()
        {
            int result = Fibonacci.Compute(10);
            Assert.Equal(55, result); // 10th Fibonacci number
        }

        [Fact]
        public void NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Fibonacci.Compute(-5));
        }
    }
}
