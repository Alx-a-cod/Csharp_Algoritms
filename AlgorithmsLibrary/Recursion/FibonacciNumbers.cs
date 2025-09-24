using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// ======================================================
// Description:     Computes nth Fibonacci number: F(0)=0, F(1)=1, F(n)=F(n-1)+F(n-2)
//                  Base cases: F(0) = 0, F(1) = 1
//                  Recursive case: F(n) = F(n-1) + F(n-2) for n > 1
//                  Easy to understand but inefficient for large n (O(2^n)).
//
// Time complexity:  O(2^n) - due to the exponential growth of recursive calls.
//
//  Space complexity: O(n) - due to call stack from recursion.
//
// ------------------------------------------------------
// Example: Compute(5) returns 5 because F(5) = F(4) + F(3) = 3 + 2 = 5
// ======================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class Fibonacci
    {
        public static int Compute(int n)
        {
            if (n < 0) throw new ArgumentException("n must be non-negative");

            if (n == 0) return 0; // Base case
            if (n == 1) return 1; // Base case

            return Compute(n - 1) + Compute(n - 2); // Recursive call
        }
    }
}
