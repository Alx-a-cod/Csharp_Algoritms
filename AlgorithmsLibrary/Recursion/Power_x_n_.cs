using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// =================================================================
// Description:      This function computes the power of a number x raised to an integer n (x^n) using recursion.
//                   It handles both positive and negative powers.
//                   Base case: If n is 0, the result is 1 (since any number to the power of 0 is 1).
//                   Recursive case: Multiply x by the result of Compute(x, n-1) for positive n.
//                   For negative n, it computes the reciprocal of Compute(x, -n).
//
// Time Complexity:  O(n) - Each recursive call reduces n by 1.
// Space Complexity: O(n) - Due to the recursion stack.
//------------------------------------------------------------------
//Example:        double result = Power_x_n_.Compute(2, 3); // result will be 8 (2^3)
// ==================================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class Power_x_n_
    {
        public static double Compute(double x, int n) 
        {
            if (n < 0) // <---- handle negative powers
                return 1 / Compute(x, -n); 

            if (n == 0) return 1; // base case

            return x * Compute(x, n - 1); // recursive call
        }
    }
}
