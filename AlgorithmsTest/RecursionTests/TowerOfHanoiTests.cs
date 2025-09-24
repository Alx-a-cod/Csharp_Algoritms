using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Recursion;
using Xunit;

// =================================================================
// TowerOfHanoi.Solve
// - n = 1 -> single move (disk 1 from A to C)
// - n = 2 -> correct 3 moves sequence
// - n = 3 -> correct 7 moves sequence
// - Larger n (e.g., 4) -> number of moves should be 2^n - 1
// - Custom peg labels -> works with different names (e.g., X, Y, Z)
// - Invalid input (n <= 0) -> should throw ArgumentException
// =================================================================

namespace AlgorithmsTest.RecursionTests
{
    public class TowerOfHanoiTests
    {
        [Fact]
        public void Solve_OneDisk_SingleMove()
        {
            var moves = TowerOfHanoi.Solve(1);
            Assert.Single(moves);
            Assert.Equal((1, 'A', 'C'), moves[0]);
        }

        [Fact]
        public void Solve_TwoDisks_CorrectSequence()
        {
            var moves = TowerOfHanoi.Solve(2);
            var expected = new List<(int, char, char)>
            {
                (1, 'A', 'B'),
                (2, 'A', 'C'),
                (1, 'B', 'C')
            };

            Assert.Equal(expected, moves);
        }

        [Fact]
        public void Solve_ThreeDisks_CorrectSequenceAndCount()
        {
            var moves = TowerOfHanoi.Solve(3);

            Assert.Equal(7, moves.Count); // 2^3 - 1 = 7
            Assert.Equal((1, 'A', 'C'), moves[0]); // first move
            Assert.Equal((3, 'A', 'C'), moves[3]); // middle move
            Assert.Equal((1, 'A', 'C'), moves[^1]); // last move
        }

        [Fact]
        public void Solve_FourDisks_CorrectMoveCount()
        {
            var moves = TowerOfHanoi.Solve(4);
            Assert.Equal(15, moves.Count); // 2^4 - 1 = 15
        }

        [Fact]
        public void Solve_CustomPegLabels_WorksCorrectly()
        {
            var moves = TowerOfHanoi.Solve(2, 'X', 'Y', 'Z');
            var expected = new List<(int, char, char)>
            {
                (1, 'X', 'Z'),
                (2, 'X', 'Y'),
                (1, 'Z', 'Y')
            };

            Assert.Equal(expected, moves);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Solve_InvalidN_ThrowsArgumentException(int n)
        {
            Assert.Throws<ArgumentException>(() => TowerOfHanoi.Solve(n));
        }
    }
}
