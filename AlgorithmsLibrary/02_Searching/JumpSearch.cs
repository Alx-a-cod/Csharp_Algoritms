// ======================================================
// Description:      For sorted arrays, jumps ahead by fixed steps instead of checking every element.
//                   Once a block where the target could be is found, it performs a linear search within that block.
//                   Optimal step size: √n
//
// Time complexity:  O(√n)
//
// Space complexity: O(1)
//
// ======================================================

namespace AlgorithmsLibrary.SearchTests
{
    public static class JumpSearch
    {
        public static int Search(int[] array, int target) // <---- public method to initiate the search
        {
            int n = array.Length; // <---- get the size of the array
            int step = (int)Math.Floor(Math.Sqrt(n)); // <---- optimal step size is √n
            int prev = 0; // <---- previous index

            while (prev < n && array[Math.Min(step, n) - 1] < target) // <---- jump ahead by step size until we find a block where target could be
            {
                prev = step; // <---- move previous to current step
                step += (int)Math.Floor(Math.Sqrt(n)); // <---- jump ahead by another step size
                if (prev >= n) return -1; // <---- if we exceed array bounds, target is not present
            }

            for (int i = prev; i < Math.Min(step, n); i++) // <---- linear search within the identified block
            {
                if (array[i] == target) // Check if current element matches target
                    return i;           // Return index if found
            }

            return -1; // Not found, 404
        }
    }
}
