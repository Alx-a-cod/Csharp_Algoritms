using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary.Sorting;
using Xunit;

// ======================================================
// Description:      Simple comparison-based sort.
//                   Repeatedly steps through the array, compares adjacent items, and swaps them if they are in the wrong order.
//                   The process is repeated until the array is sorted.
//
// Time complexity:  O(n²) average/worst, O(n) best (if already sorted).
//
// Space complexity: O(1) (in-place).
//
// ======================================================

namespace AlgorithmsLibrary.Sorting
{
    public static class BubbleSort
    {
        // Sort int[] arrays
        public static void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Sort tuple arrays for stability
        public static void Sort((int val, int id)[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].val > arr[j + 1].val)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}


//also single method working for any type: 

//public static void Sort<T>(T[] array, Func<T, int> keySelector)
//{
//    int n = array.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if (keySelector(array[j]) > keySelector(array[j + 1]))
//            {
//                var temp = array[j];
//                array[j] = array[j + 1];
//                array[j + 1] = temp;
//            }
//        }
//    }
//}