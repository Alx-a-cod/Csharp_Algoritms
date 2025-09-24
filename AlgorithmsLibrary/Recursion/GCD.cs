using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// ======================================================
// Description:     Computes the Greatest Common Divisor (GCD) of two integers using the Euclidean algorithm.
//                  Base case: GCD(a, 0) = a
//                  Recursive case: GCD(a, b) = GCD(b, a % b) for b > 0
//
// Time complexity:  O(log(min(a, b))) - due to the properties of the Euclidean algorithm.
// Space complexity: O(log(min(a, b))) - due to call stack from recursion.
// ------------------------------------------------------
// Example: Compute(48, 18) returns 6 because GCD(48, 18) = 6
// ======================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class GCD
    {
        public static int Compute(int a, int b)
        {
            if (b == 0) return a; // Base case
            return Compute(b, a % b); // Recursive call
        }
    }
}
