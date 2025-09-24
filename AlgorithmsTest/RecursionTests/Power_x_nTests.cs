using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AlgorithmsLibrary.Recursion;

// =================================================================
// What to Test:
//
// Base case: x^0 = 1 for any x ≠ 0
// Positive exponents: check correctness for small numbers
// Negative exponents: should return reciprocal (1 / x^n)
// Edge case: x = 0 with positive n (should return 0)
// Edge case: x = 0 with n = 0 (mathematically undefined, currently returns 1)
// Edge case: x = 0 with negative n (division by zero → should throw)
// Fractional base: confirm recursion works for non-integers
// Large exponents: ensure recursion depth works, but avoid stack overflow. With tolerance for floating-point precision.
// =================================================================


namespace AlgorithmsTest.RecursionTests
{
    public class Power_x_n_Tests
    {
        [Fact]
        public void BaseCase_ExponentZero_ReturnsOne()
        {
            Assert.Equal(1, Power_x_n_.Compute(5, 0));
            Assert.Equal(1, Power_x_n_.Compute(-3, 0));
            Assert.Equal(1, Power_x_n_.Compute(0, 0)); // implementation choice
        }

        [Fact]
        public void PositiveExponent_ReturnsCorrectResult()
        {
            Assert.Equal(8, Power_x_n_.Compute(2, 3));
            Assert.Equal(81, Power_x_n_.Compute(3, 4));
            Assert.Equal(-27, Power_x_n_.Compute(-3, 3));
        }

        [Fact]
        public void NegativeExponent_ReturnsReciprocal()
        {
            Assert.Equal(0.5, Power_x_n_.Compute(2, -1), 5);
            Assert.Equal(0.25, Power_x_n_.Compute(2, -2), 5);
            Assert.Equal(-0.125, Power_x_n_.Compute(-2, -3), 5);
        }

        [Fact]
        public void ZeroBase_PositiveExponent_ReturnsZero()
        {
            Assert.Equal(0, Power_x_n_.Compute(0, 5));
        }

        [Fact]
        public void ZeroBase_NegativeExponent_ThrowsDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Power_x_n_.Compute(0, -3));
        }

        [Fact]
        public void FractionalBase_ReturnsCorrectResult()
        {
            Assert.Equal(0.125, Power_x_n_.Compute(0.5, 3), 5);
            Assert.Equal(4.0, Power_x_n_.Compute(2.0, 2), 5);
        }

        [Fact]
        public void LargeExponent_WorksCorrectly()
        {
            double result = Power_x_n_.Compute(2, 10);
            Assert.Equal(1024, result);
        }
    }
}
