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
            if (n < 0) // <---- handle negative powers, nut then 0.0? Infinity --> IEEE floating point. Then:
            {
                //if (x == 0.0)
                //    throw new DivideByZeroException("0 cannot be raised to a negative power."); // <--- handle division by zero for negative powers of 0.
                //return 1.0 / Compute(x, -n);
                if (x == 0.0)
                    throw new DivideByZeroException("0 cannot be raised to a negative power.");

                // convert to long to avoid overflow when n == int.MinValue
                return 1.0 / PowPositive(x, -(long)n);
            }
            return PowPositive(x, n);
        }

        //if (n == 0) return 1.0; // base case

        //return x * Compute(x, n - 1); // recursive call

        private static double PowPositive(double x, long n) // <---- helper method to handle positive powers using iterative approach to avoid deep recursion.
        {
            double result = 1.0; // <---- initialize result to 1.
            double baseVal = x; // <---- start with the base value x.
            while (n > 0) // <---- loop until n is reduced to 0.
            {
                if ((n & 1) == 1) result *= baseVal; // <---- if n is odd, multiply the result by the current base value.
                baseVal *= baseVal; // <---- square the base value for the next iteration.
                n >>= 1; // <---- divide n by 2 (right shift) to reduce the exponent.
            }
            return result; // <---- return the computed power.
        }
    }
}
