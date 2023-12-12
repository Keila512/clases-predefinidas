using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // STACK
        Console.WriteLine("Stack:");
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        while (stack.Count > 0)
        {
            int poppedItem = stack.Pop();
            Console.WriteLine($"Stack element: {poppedItem}");
        }

        // QUEUE
        Console.WriteLine("\nQueue:");
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        while (queue.Count > 0)
        {
            string dequeuedItem = queue.Dequeue();
            Console.WriteLine($"Queue element: {dequeuedItem}");
        }

        // LINKED LISTS
        Console.WriteLine("\nLinked Lists:");
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("Start");
        linkedList.AddLast("Half");
        linkedList.AddLast("End");

        foreach (string item in linkedList)
        {
            Console.WriteLine($"Linked list element: {item}");
        }
    }
}