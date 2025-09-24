using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.SortTests;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class BubbleSortTests
    {
        [Fact]
        public void Sort_SortsUnsortedArray()
        {
            int[] arr = { 5, 2, 9, 1, 5 };
            BubbleSort.Sort(arr);
            Assert.Equal(new int[] { 1, 2, 5, 5, 9 }, arr);
        }

        [Fact]
        public void Sort_EmptyArray_NoChange()
        {
            int[] arr = Array.Empty<int>();
            BubbleSort.Sort(arr);
            Assert.Empty(arr);
        }

        [Fact]
        public void Sort_SingleElement_NoChange()
        {
            int[] arr = { 42 };
            BubbleSort.Sort(arr);
            Assert.Equal(new int[] { 42 }, arr);
        }

        [Fact]
        public void Sort_AlreadySorted_NoChange()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            BubbleSort.Sort(arr);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void Sort_ReverseArray_SortsCorrectly()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            BubbleSort.Sort(arr);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
        }
    }
}
