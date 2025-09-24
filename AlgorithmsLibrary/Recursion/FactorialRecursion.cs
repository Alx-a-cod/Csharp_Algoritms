using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// ======================================================
// Description:     Computes the factorial of a non-negative integer n using recursion.
//                  Factorial of n (n!) is the product of all positive integers up to n.
//                  Base case: 0! = 1
//                  Recursive case: n! = n * (n-1)! for n > 0
//
// Time complexity:  O(n) - due to n recursive calls.
//
// Space complexity: O(n) - due to call stack from recursion.
//
// ------------------------------------------------------
// Example: Compute(5) returns 120 because 5! = 5 * 4 * 3 * 2 * 1 = 120
// ======================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class FactorialRecursion
    {
        public static int Compute(int n)
        {
            if (n < 0) throw new ArgumentException("n must be non-negative"); // <--- Handle negative input

            if (n == 0) return 1; // Base case: 0! = 1

            return n * Compute(n - 1); // Recursive call
        }
    }
}
