using System;
using AlgorithmsLibrary.Sorting;
using AlgorithmsLibrary.Searching;
using AlgorithmsLibrary.Recursion;
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
                Console.WriteLine("3. Recursion Algorithms");
                //Console.WriteLine("3. Data Structures Demo");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": SortingMenu(); break;
                    case "2": SearchingMenu(); break;
                    case "3": RecursionMenu(); break;
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

        #region Menus

        #region Sorting Menu

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

        #endregion Sorting Menu

        #region Searching Menu

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

        #endregion Searching Menu

        #region Recursion Menu


        static void RecursionMenu()
        {
            Console.WriteLine("\n--- Recursion Algorithms ---");
            Console.WriteLine("1 = ArraySum");
            Console.WriteLine("2 = BinarySearch (Recursive)");
            Console.WriteLine("3 = Factorial");
            Console.WriteLine("4 = Fibonacci Numbers");
            Console.WriteLine("5 = GCD (Greatest Common Divisor)");
            Console.WriteLine("6 = Power(x, n)");
            Console.WriteLine("7 = Reverse String");
            Console.WriteLine("8 = Tower of Hanoi");
            Console.Write("Your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // ArraySum
                    Console.WriteLine("Enter numbers separated by space:");
                    int[] array = Array.ConvertAll(
                        Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>(),
                        s => int.TryParse(s, out int n) ? n : 0
                    );
                    Console.WriteLine("Sum = " + ArraySum.Compute(array));
                    break;

                case "2": // BinarySearchRecursive
                    Console.WriteLine("Enter sorted numbers separated by space:");
                    int[] sortedArray = Array.ConvertAll(
                        Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>(),
                        s => int.TryParse(s, out int n) ? n : 0
                    );

                    Console.Write("Enter target value: ");
                    int target = int.TryParse(Console.ReadLine(), out int t) ? t : 0;

                    int index = BinarySearchRecursive.Search(sortedArray, target);
                    Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Target not found");
                    break;

                case "3": // FactorialRecursion <---- checks for negative input before callling and handles invalid or empty as gracefully as we can given the project. Meaning: we do not crash. Hopefully.
                    Console.Write("Enter n (non-negative integer): ");
                    if (int.TryParse(Console.ReadLine(), out int nFact))
                    {
                        if (nFact < 0)
                        {
                            Console.WriteLine("Invalid input: n must be non-negative!");
                        }
                        else
                        {
                            Console.WriteLine("Factorial = " + FactorialRecursion.Compute(nFact));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    break;

                case "4": // Fibonacci <---null-safe with negative validation ;)
                    Console.Write("Enter n (non-negative integer): ");
                    if (int.TryParse(Console.ReadLine(), out int nFib))
                    {
                        if (nFib < 0)
                        {
                            Console.WriteLine("Invalid input: n must be non-negative!");
                        }
                        else
                        {
                            Console.WriteLine($"Fibonacci({nFib}) = {Fibonacci.Compute(nFib)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    break;

                case "5": // GCD <--- null-safe with validation for integers, AND safe-parsing. Added Math.Abs to ensure we handle negative inputs gracefully, as GCD is typically defined for non-negative integers. YEEET.
                    Console.Write("Enter first number: ");
                    bool validA = int.TryParse(Console.ReadLine(), out int a);
                    Console.Write("Enter second number: ");
                    bool validB = int.TryParse(Console.ReadLine(), out int b);

                    if (!validA || !validB)
                    {
                        Console.WriteLine("Invalid input! Please enter integers.");
                    }
                    else
                    {
                        Console.WriteLine($"GCD({a}, {b}) = {GCD.Compute(a, b)}");
                    }
                    break;

                case "6": // Power_x_n_ <--- accepts double base and integer exponent. Catches DividedByZeroException for 0 raised to negative power. Because safe is better than crashing. :D
                    Console.Write("Enter base x: ");
                    bool validX = double.TryParse(Console.ReadLine(), out double x);
                    Console.Write("Enter exponent n (integer): ");
                    bool validN = int.TryParse(Console.ReadLine(), out int nPow);

                    if (!validX || !validN)
                    {
                        Console.WriteLine("Invalid input! Please enter a number for x and an integer for n.");
                    }
                    else
                    {
                        try
                        {
                            double result = Power_x_n_.Compute(x, nPow);
                            Console.WriteLine($"{x}^{nPow} = {result}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                    break;

                case "7": // Reverse <---- CHOICES! Null-safe, with empty input handling.
                    Console.WriteLine("Choose type to reverse:");
                    Console.WriteLine("1 = String");
                    Console.WriteLine("2 = Array of integers");
                    Console.Write("Your choice: ");
                    string? revChoice = Console.ReadLine();

                    if (revChoice == "1") // String
                    {
                        Console.Write("Enter string to reverse: ");
                        string input = Console.ReadLine() ?? "";
                        if (string.IsNullOrEmpty(input))
                            Console.WriteLine("Input is empty!");
                        else
                            Console.WriteLine("Reversed string: " + Reverse.String(input));
                    }
                    else if (revChoice == "2") // Array
                    {
                        Console.WriteLine("Enter numbers separated by space:");
                        int[] arrInput = Array.ConvertAll(
                            Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>(),
                            s => int.TryParse(s, out int n) ? n : 0
                        );

                        Reverse.Array(arrInput); // in-place reversal
                        Console.WriteLine("Reversed array: " + string.Join(", ", arrInput));
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!");
                    }
                    break;


                case "8": // Tower of Hanoi <--- null safe. And prints all moves + sanity check showing total moves and the expected count.
                    Console.Write("Enter number of disks (positive integer): ");
                    if (int.TryParse(Console.ReadLine(), out int disks) && disks > 0)
                    {
                        var moves = TowerOfHanoi.Solve(disks);

                        Console.WriteLine($"\nTower of Hanoi solution for {disks} disks:");
                        foreach (var move in moves)
                        {
                            Console.WriteLine($"Move disk {move.disk} from {move.from} to {move.to}");
                        }

                        Console.WriteLine($"\nTotal moves: {moves.Count} (should be 2^{disks} - 1 = {Math.Pow(2, disks) - 1})");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a positive integer.");
                    }
                    break;

            }

            #endregion Recursion Menu

        #endregion menus
        }
    }
}

