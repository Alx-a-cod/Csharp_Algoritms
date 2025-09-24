using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;

// =================================================================
// Description:      This class provides a method to solve the Tower of Hanoi problem using recursion.
//                   The method returns a list of moves required to transfer n disks from the source peg to the target peg using an auxiliary peg.
//                   Base case: If there is only one disk, move it directly from source to target.
//                   Recursive case: Move n-1 disks from source to auxiliary, move the nth disk from source to target, then move n-1 disks from auxiliary to target.
//
// Time Complexity:  O(2^n) - Each disk move involves two recursive calls for n-1 disks plus one move for the nth disk.
// Space Complexity: O(n) - Due to the recursion stack.
//------------------------------------------------------------------
// Example:        var moves = TowerOfHanoi.Solve(3);
//                 moves will contain the sequence of moves to solve the puzzle for 3 disks.
//=================================================================

namespace AlgorithmsLibrary.Recursion
{
    public static class TowerOfHanoi
    {
        // Record moves as tuples (disk, from, to)
        public static List<(int disk, char from, char to)> Solve(int n, char source = 'A', char target = 'C', char auxiliary = 'B')
        {
            var moves = new List<(int, char, char)>(); //<---- List to store the moves
            SolveRecursive(n, source, target, auxiliary, moves); //<---- Call the recursive helper method
            return moves; // <---- Return the list of moves
        }

        private static void SolveRecursive(int n, char source, char target, char auxiliary, List<(int, char, char)> moves)
        {
            if (n == 1) //<---- Base case: only one disk to move
            {
                moves.Add((1, source, target)); // <---- Move disk 1 directly from source to target
                return;
            }

            SolveRecursive(n - 1, source, auxiliary, target, moves); // <---- Move n-1 disks from source to auxiliary
            moves.Add((n, source, target)); // <---- Move the nth disk from source to target
            SolveRecursive(n - 1, auxiliary, target, source, moves); // <---- Move n-1 disks from auxiliary to target
        }
    }
}
