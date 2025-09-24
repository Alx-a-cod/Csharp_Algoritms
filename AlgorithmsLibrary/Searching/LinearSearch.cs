using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Searching;
using Xunit;

// ======================================================
// Description:      Simple search algorithm that scans each element until the target is found..
//                   Works for unsorted arrays.
// Time complexity:  O(n)
//
// Space complexity: O(1)
//
// ======================================================

namespace AlgorithmsLibrary.Searching
{
    public static class LinearSearch
    {
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++) // <---- iterate through each element of the array from 0 to length-1
            {
                if (array[i] == target) // Check if current element matches target
                    return i;           // Return index if found
            }
            return -1; // Not found, loop finishes without finding target
        }
    }
}
