using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// ======================================================
// Description:     Computes the sum of all elements in an integer array using recursion.
//                  Base case: empty array sum is 0
//                  Recursive case: sum of first n elements = sum of first (n-1) elements + nth element
//
// Time complexity:  O(n) - due to n recursive calls.
// Space complexity: O(n) - due to call stack from recursion.
//------------------------------------------------------
//Example: Compute([1,2,3,4]) returns 10 because 1+2+3+4=10
// ======================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class ArraySum
    {
        public static int Compute(int[] array, int n = -1)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (n == -1) n = array.Length; // default to full array

            if (n == 0) return 0; // Base case: empty array

            return Compute(array, n - 1) + array[n - 1]; // sum previous elements + last element
        }
    }
}
