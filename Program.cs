using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Push(1);
            ll.Push(2);
            ll.Push(3);
            List<int> allValues = ll.LinkedListValues();
            Console.WriteLine($"The head of the Linked List Linked has a value of {ll.Head.Value.ToString()}, its next value is {ll.Head.Next.Value.ToString()}");
            Console.WriteLine($"The Size of the Linked List is {ll.Size.ToString()}");
            Console.WriteLine("All node values: " + string.Join(", ", allValues));
        }
    }
}
