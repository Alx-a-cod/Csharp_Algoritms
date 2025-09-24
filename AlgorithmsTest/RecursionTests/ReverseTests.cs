using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AlgorithmsLibrary.Recursion;

namespace AlgorithmsTest.RecursionTests
{
    public class ReverseTests
    {
        // ---- STRING TESTS ----
        [Fact]
        public void String_Empty_ReturnsEmpty()
        {
            Assert.Equal("", Reverse.String(""));
        }

        [Fact]
        public void String_SingleCharacter_ReturnsSameCharacter()
        {
            Assert.Equal("a", Reverse.String("a"));
        }

        [Fact]
        public void String_NormalString_ReversedCorrectly()
        {
            Assert.Equal("olleh", Reverse.String("hello"));
            Assert.Equal("321cba", Reverse.String("abc123"));
        }

        [Fact]
        public void String_Palindrome_ReturnsSame()
        {
            Assert.Equal("racecar", Reverse.String("racecar"));
        }

        [Fact]
        public void String_WithSpacesAndSymbols_ReversedCorrectly()
        {
            Assert.Equal("!dlroW olleH", Reverse.String("Hello World!"));
        }

        // ---- ARRAY TESTS ----
        [Fact]
        public void Array_Empty_RemainsEmpty()
        {
            int[] arr = Array.Empty<int>();
            Reverse.Array(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void Array_SingleElement_RemainsUnchanged()
        {
            int[] arr = { 42 };
            Reverse.Array(arr);
            Assert.Equal(new[] { 42 }, arr);
        }

        [Fact]
        public void Array_EvenLength_ReversedCorrectly()
        {
            int[] arr = { 1, 2, 3, 4 };
            Reverse.Array(arr);
            Assert.Equal(new[] { 4, 3, 2, 1 }, arr);
        }

        [Fact]
        public void Array_OddLength_ReversedCorrectly()
        {
            string[] arr = { "a", "b", "c", "d", "e" };
            Reverse.Array(arr);
            Assert.Equal(new[] { "e", "d", "c", "b", "a" }, arr);
        }

        [Fact]
        public void Array_GenericTypes_ReversedCorrectly()
        {
            char[] arr = { 'x', 'y', 'z' };
            Reverse.Array(arr);
            Assert.Equal(new[] { 'z', 'y', 'x' }, arr);
        }
    }
}
