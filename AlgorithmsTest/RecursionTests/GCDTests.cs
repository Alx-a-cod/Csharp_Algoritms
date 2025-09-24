using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AlgorithmsLibrary.Recursion;

// ======================================================
// What to Test:
//
// Base case: GCD(a, 0) = a
// Symmetry: GCD(a, b) = GCD(b, a)
// Typical numbers: small and large examples
// Coprime numbers: GCD(a, b) = 1
// Equal numbers: GCD(a, a) = a
// Negative numbers: should return positive GCD
// Zeros: GCD(0, 0) is mathematically undefined,
//        but implementation will return 0 (check this behavior).
// ======================================================


namespace AlgorithmsTest.RecursionTests
{
    public class GCDTests
    {
        [Fact]
        public void BaseCase_SecondArgumentZero_ReturnsFirstArgument()
        {
            Assert.Equal(10, GCD.Compute(10, 0));
            Assert.Equal(25, GCD.Compute(25, 0));
        }

        [Fact]
        public void Symmetry_ReturnsSameResult()
        {
            int result1 = GCD.Compute(48, 18);
            int result2 = GCD.Compute(18, 48);

            Assert.Equal(result1, result2);
            Assert.Equal(6, result1);
        }

        [Fact]
        public void CoprimeNumbers_ReturnsOne()
        {
            Assert.Equal(1, GCD.Compute(35, 64)); // 35 and 64 are coprime
        }

        [Fact]
        public void EqualNumbers_ReturnsSameNumber()
        {
            Assert.Equal(12, GCD.Compute(12, 12));
            Assert.Equal(100, GCD.Compute(100, 100));
        }

        [Fact]
        public void HandlesNegativeNumbers_ReturnsPositiveGcd()
        {
            Assert.Equal(6, GCD.Compute(-48, 18));
            Assert.Equal(6, GCD.Compute(48, -18));
            Assert.Equal(6, GCD.Compute(-48, -18));
        }

        [Fact]
        public void BothZero_ReturnsZero()
        {
            Assert.Equal(0, GCD.Compute(0, 0)); // current implementation returns 0
        }

        [Fact]
        public void TypicalNumbers_ReturnsCorrectGcd()
        {
            Assert.Equal(6, GCD.Compute(48, 18));
            Assert.Equal(14, GCD.Compute(42, 56));
            Assert.Equal(1, GCD.Compute(17, 31));
        }
    }
}
