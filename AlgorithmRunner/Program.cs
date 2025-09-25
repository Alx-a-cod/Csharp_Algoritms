using System;
using AlgorithmsLibrary.Sorting;
using AlgorithmsLibrary.Searching;
using MathNet.Numerics.Distributions;

namespace AlgorithmRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Algorithms Runner ==="); //<°)))>< we adding 'em as we GO!!!
                Console.WriteLine("1. Sorting Algorithms");
                Console.WriteLine("2. Searching Algorithms");
                //Console.WriteLine("3. Data Structures Demo");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": SortingMenu(); break;
                    case "2": SearchingMenu(); break;
                    //case "3": DataStructuresDemo(); break; <--- next one coming
                    case "4": exit = true; break;
                    default: Console.WriteLine("Invalid option!"); break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to return to main menu...");
                    Console.ReadKey();
                }
            }
        }

        static void SortingMenu()
        {
            Console.WriteLine("\n--- Sorting Algorithms ---");
            Console.WriteLine("Enter numbers separated by space:");

            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided!");
                return;
            }

            int[] array;
            try
            {
                array = Array.ConvertAll(
                    input.Split(' ', StringSplitOptions.RemoveEmptyEntries),
                    s => int.TryParse(s, out int n) ? n : throw new FormatException($"Invalid number: {s}")
                );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Choose algorithm:");
            Console.WriteLine("1=BubbleSort");
            Console.WriteLine("2=CountingSort");
            Console.WriteLine("3=HeapSort");
            Console.WriteLine("4=InsertionSort");
            Console.WriteLine("5=MergeSort");
            Console.WriteLine("6=QuickSort");
            Console.WriteLine("7=RadixSort");
            Console.WriteLine("8=SelectionSort");
            Console.Write("Your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": BubbleSort.Sort(array); break;
                case "2": CountingSort.Sort(array); break;
                case "3": HeapSort.Sort(array); break;
                case "4": InsertionSort.Sort(array); break;
                case "5": MergeSort.Sort(array); break;
                case "6": QuickSort.Sort(array); break;
                case "7": RadixSort.Sort(array); break;
                case "8": SelectionSort.Sort(array); break;
                default: Console.WriteLine("Invalid choice!"); return;
            }

            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void SearchingMenu()
        {
            Console.WriteLine("\n--- Searching Algorithms ---");
            Console.WriteLine("Enter sorted numbers separated by space:");

            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided!");
                return;
            }

            int[] array;
            try
            {
                array = Array.ConvertAll(
                    input.Split(' ', StringSplitOptions.RemoveEmptyEntries),
                    s => int.TryParse(s, out int n) ? n : throw new FormatException($"Invalid number: {s}")
                );
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.Write("Enter target value to search: ");
            string? targetInput = Console.ReadLine();
            if (!int.TryParse(targetInput, out int target))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            Console.WriteLine("Choose search algorithm:");
            Console.WriteLine("1 = LinearSearch");
            Console.WriteLine("2 = BinarySearch");
            Console.WriteLine("3 = ExponentialSearch");
            Console.WriteLine("4 = JumpSearch");
            Console.WriteLine("5 = TernarySearch");
            // Console.WriteLine("6 = InterpolationSearch"); // want to add it later. REMEMBER! Here the placeholder: 🦆
            string? choice = Console.ReadLine();

            int index = -1;
            switch (choice)
            {
                case "1": index = LinearSearch.Search(array, target); break;
                case "2": index = BinarySearch.Search(array, target); break;
                case "3": index = ExponentialSearch.Search(array, target); break;
                case "4": index = JumpSearch.Search(array, target); break;
                case "5": index = TernarySearch.Search(array, target); break;
                // case "6": index = InterpolationSearch.Search(array, target); break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine(index >= 0
                ? $"Target found at index {index}"
                : "Target not found");
        }
    }
}
