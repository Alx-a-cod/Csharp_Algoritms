# 🧩 C# Algorithms Library

 **Plug, Play & Learn** – A modular, ready-to-use collection of algorithms and data structures in C#, with a runner and unit tests. Perfect for learning, practicing, or referencing.   
`Mostly referencing, let's be honest about it.`

---

#### 📍 Overview

This project is a **C# algorithms playground** designed for developers, students, and enthusiasts who want a structured, modular, and ready-to-run library of algorithms.  

It includes:  

- **A class library** (`AlgorithmsLibrary`) organized by algorithm category  
- **A console runner** (`AlgorithmsRunner`) to quickly test any algorithm  
- **Unit tests** (`AlgorithmsTests`) built with **xUnit**  
- Algorithms ranging from **beginner-friendly** to... **begineer-friendly**.
`I apologize.`
`First of all to myself.`

---

#### 📍 Core Features

- Modular folder structure for easy navigation  
- Ready-to-use `.cs` files for each algorithm  
- Plug & play in your projects  
- Step-by-step examples in the runner  
- Unit tests to ensure correctness  
- Covers **Sorting, Searching, Recursion, Data Structures, Dynamic Programming, Graphs, Strings, Cryptography, and Advanced Algorithms**  

---

#### 📍 Architecture

- **AlgorithmsLibrary (Class Library)** – Modular `.cs` files, one per algorithm  
- **AlgorithmsRunner (Console App)** – Test and demonstrate algorithms easily  
- **AlgorithmsTests (xUnit)** – Ensure reliability and correctness  

All components are **loosely coupled**, making it easy to expand or integrate into other projects. ;)

---

#### 📍 Algorithm Categories

##### 📘 Beginner (Fundamentals)

- Linear Search  
- Binary Search  
- Bubble Sort  
- Selection Sort  
- Insertion Sort  
- Merge Sort  
- Quick Sort  
- Factorial (recursion & loop)  
- Fibonacci Sequence  
- Palindrome Checker  
- Prime Number Check  
- Greatest Common Divisor (Euclid)  
- Least Common Multiple  

##### 📗 Intermediate (Classic CS Stuff)

- Hashing basics (Dictionary usage, custom hash)  
- Stack (arrays & linked lists)  
- Queue & Circular Queue  
- Linked List (Singly, Doubly)  
- Binary Tree (insert, traverse, search)  
- Binary Search Tree (BST)  
- Heap (MinHeap, MaxHeap)  
- Priority Queue  
- Dynamic Programming: Fibonacci DP, Knapsack 0/1, Coin Change  
- Greedy Algorithms: Activity Selection, Huffman Coding  

##### 📙 Advanced (Serious Stuff)

- Graph Representations (Adjacency List, Matrix)  
- Depth First Search (DFS)  
- Breadth First Search (BFS)  
- Dijkstra’s Shortest Path  
- Bellman-Ford  
- Floyd-Warshall  
- A* Search  
- Kruskal’s & Prim’s MST  
- Topological Sort, Kahn’s Algorithm  
- Tarjan’s Algorithm (SCC)  
- KMP & Rabin-Karp String Matching  
- Trie (Prefix Tree)  
- Union-Find (Disjoint Set)  

##### 📕 Expert (I want to cry)

- Segment Trees (with Lazy Propagation)  
- Fenwick Tree (Binary Indexed Tree)  
- Suffix Array / Suffix Tree  
- String Hashing & Rolling Hash  
- Matrix Exponentiation  
- Fast Fourier Transform (FFT)  
- Miller-Rabin Primality Test  
- RSA Cryptography (basic implementation)  
- Elliptic Curve basics  
- Multithreading / Parallel Algorithms (TPL / async)  
- Distributed Consensus (Raft / Paxos – simplified)  

---

## 📍 Folder Organization & Algorithms

This tree shows the **solution, projects, folders**, and all algorithms organized by category:

```text
AlgorithmsLibrary.sln
│
├── AlgorithmsLibrary (Class Library)
│   ├── Sorting
│   │   ├── BubbleSort.cs                 # 📘 Beginner
│   │   ├── CountingSort.cs               # 📘 Beginner
│   │   ├── HeapSort.cs                   # 📘 Beginner
│   │   ├── InsertionSort.cs              # 📘 Beginner
│   │   ├── MergeSort.cs                  # 📘 Beginner
│   │   └── QuickSort.cs                  # 📘 Beginner
│   │   ├── RadixSort.cs                  # 📘 Beginner
│   │   ├── SelectionSort.cs              # 📘 Beginner
│   │
│   ├── Searching
│   │   └── BinarySearch.cs               # 📘 Beginner
│   │   ├── ExponentialSearchSearch.cs    # 📘 Beginner
│   │   ├── JumpSearch.cs                 # 📘 Beginner
│   │   ├── LinearSearch.cs               # 📘 Beginner
│   │   ├── TernarySearch.cs              # 📘 Beginner
│   │
│   ├── Recursion
│   │   ├── ArraySum.cs                   # 📘 Beginner
│   │   ├── BinarySearch(Recursive).cs    # 📘 Beginner
│   │   ├── FactorialRecursion.cs         # 📘 Beginner
│   │   ├── FibonacciNumbers.cs           # 📘 Beginner
│   │   ├── GCD.cs                        # 📘 Beginner
│   │   ├── Power(x_n).cs                 # 📘 Beginner
│   │   ├── Reverse.cs                    # 📘 Beginner
│   │   ├── TowerOfHanoi.cs               # 📘 Beginner
│   │   └── PalindromeChecker.cs          # 📘 Beginner
│   │
│   ├── Math 
│   │   ├── PrimeNumberCheck.cs           # 📘 Beginner
│   │   ├── GreatestCommonDivisor.cs      # 📘 Beginner
│   │   └── LeastCommonMultiple.cs        # 📘 Beginner
│   │
│   ├── DataStructures
│   │   ├── Stack.cs                      # 📗 Intermediate
│   │   ├── Queue.cs                      # 📗 Intermediate
│   │   ├── CircularQueue.cs              # 📗 Intermediate
│   │   ├── LinkedList.cs                 # 📗 Intermediate
│   │   ├── BinaryTree.cs                 # 📗 Intermediate
│   │   ├── BinarySearchTree.cs           # 📗 Intermediate
│   │   ├── Heap.cs                       # 📗 Intermediate
│   │   └── PriorityQueue.cs              # 📗 Intermediate
│   │
│   ├── DynamicProgramming
│   │   ├── FibonacciDP.cs               # 📗 Intermediate
│   │   ├── Knapsack01.cs                 # 📗 Intermediate
│   │   └── CoinChange.cs                 # 📗 Intermediate
│   │
│   ├── Greedy
│   │   ├── ActivitySelection.cs          # 📗 Intermediate
│   │   └── HuffmanCoding.cs              # 📗 Intermediate
│   │
│   ├── Graphs
│   │   ├── GraphRepresentation.cs        # 📙 Advanced
│   │   ├── DFS.cs                        # 📙 Advanced
│   │   ├── BFS.cs                        # 📙 Advanced
│   │   ├── Dijkstra.cs                    # 📙 Advanced
│   │   ├── BellmanFord.cs                 # 📙 Advanced
│   │   ├── FloydWarshall.cs               # 📙 Advanced
│   │   ├── AStar.cs                       # 📙 Advanced
│   │   ├── KruskalMST.cs                  # 📙 Advanced
│   │   ├── PrimMST.cs                     # 📙 Advanced
│   │   ├── TopologicalSort.cs             # 📙 Advanced
│   │   ├── KahnAlgorithm.cs               # 📙 Advanced
│   │   ├── TarjanSCC.cs                   # 📙 Advanced
│   │   └── UnionFind.cs                   # 📙 Advanced
│   │
│   ├── Strings
│   │   ├── KMP.cs                         # 📙 Advanced
│   │   ├── RabinKarp.cs                   # 📙 Advanced
│   │   └── Trie.cs                        # 📙 Advanced
│   │
│   ├── Cryptography
│   │   ├── RSA.cs                          # 📕 Expert
│   │   ├── EllipticCurveBasics.cs          # 📕 Expert
│   │   └── MillerRabinPrimalityTest.cs     # 📕 Expert
│   │
│   └── Advanced
│       ├── SegmentTree.cs                  # 📕 Expert
│       ├── FenwickTree.cs                  # 📕 Expert
│       ├── SuffixArray.cs                  # 📕 Expert
│       ├── SuffixTree.cs                   # 📕 Expert
│       ├── StringHashing.cs                # 📕 Expert
│       ├── RollingHash.cs                  # 📕 Expert
│       ├── MatrixExponentiation.cs         # 📕 Expert
│       ├── FFT.cs                          # 📕 Expert
│       ├── ParallelAlgorithms.cs           # 📕 Expert
│       └── DistributedConsensus.cs         # 📕 Expert
│
├── AlgorithmsRunner (Console App)
│   └── Program.cs
│
└── AlgorithmsTests (xUnit, optional)
    ├── SortingTests.cs
    └── SearchingTests.cs
    └── ... ... ... 

```
---

#### 📍 Tech Stack

- **Language:** C# 
- **IDE:** Visual Studio 2022 / VS Code  
- **Testing:** xUnit  
- **Project Type:** .NET 8 (Class Library + Console App + Unit Tests)

---

#### 📍 Progress Status

| Category | Status |
|----------|--------|
| Beginner | ✅ Complete | `<--- (do I *want* to make a Math class?)`
| Intermediate | ⚡ In Progress |
| Advanced | ⚡ In Progress |
| Expert | 🔜 Planned |

---

#### ✨ Contribution

Contributions are welcome!

- Add missing algorithms  
- Improve runner examples
- Add new test cases
- Suggest improvements to structure or documentation  

---

🔖 ###### License: ApacheSpark2.0


