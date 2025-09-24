using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// =================================================================
// Description:      This class provides methods to reverse a string and an array using recursion.
//                   For the string reversal, the base case is when the string is empty or has one character, in which case it returns the string as is.
//                   For the array reversal, the base case is when the left index is greater than or equal to the right index, indicating that all elements have been swapped.
//                   The recursive case for the string involves concatenating the last character with the reversed substring excluding the last character.
//                   The recursive case for the array involves swapping the elements at the left and right indices and then recursively calling the function with the next inner pair of indices.
//
// Time Complexity:  O(n) - Each character/element is processed once.
// Space Complexity: O(n) for string reversal due to substring creation, O(n) for array reversal due to recursion stack.
//------------------------------------------------------------------
// Example:        string reversedString = Reverse.String("hello"); // reversedString will be "olleh"
//==================================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class Reverse
    {
        public static string String(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return s; // base case

            return s[^1] + String(s.Substring(0, s.Length - 1)); // <---- last char + recursive call with substring excluding last char
        }

        public static void Array<T>(T[] array, int left = 0, int right = -1) // <---- right default to -1 to indicate not set
        {
            if (right == -1) right = array.Length - 1; // <---- set right to last index if not provided

            if (left >= right) return; // base case

            // swap
            T temp = array[left]; // <---- swap elements at left and right indices
            array[left] = array[right]; // <---- swap elements at left and right indices
            array[right] = temp; // <---- swap elements at left and right indices

            Array(array, left + 1, right - 1); // <---- recursive call with next inner pair
        }
    }

}
