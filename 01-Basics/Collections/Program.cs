// Demonstrates important collection types in C#
using System.Collections.Generic;

class Program
{
    static void DemoList()
    {
        List<int> numbers = new List<int> { 10, 20, 30 };
        numbers.Add(40);
        numbers.Remove(20);

        Console.WriteLine("List: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void DemoDictionary()
    {
        Dictionary<string, string> capitals = new Dictionary<string, string>
        {
            { "India", "New Delhi" },
            { "France", "Paris" },
            { "Japan", "Tokyo" }
        };

        Console.WriteLine("Dictionary:");
        Console.WriteLine("India -> " + capitals["India"]);
        Console.WriteLine("France -> " + capitals["France"]);
        Console.WriteLine();
    }

    static void DemoSet()
    {
        HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Alice", "Charlie" };

        Console.WriteLine("HashSet (unique values only): ");
        foreach (string name in names)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void DemoStack()
    {
        Stack<string> books = new Stack<string>();
        books.Push("C# Basics");
        books.Push("OOP");
        books.Push("Collections");

        Console.WriteLine("Stack (LIFO):");
        while (books.Count > 0)
        {
            Console.WriteLine("Pop: " + books.Pop());
        }
        Console.WriteLine();
    }

    static void DemoQueue()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("Queue (FIFO):");
        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine("Dequeue: " + queue.Dequeue());
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        DemoList();
        DemoDictionary();
        DemoSet();
        DemoStack();
        DemoQueue();
    }
}
