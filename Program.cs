using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree b1 = new BinarySearchTree();
            // [1,2,3,4,5]
            b1.Insert(3);
            b1.Insert(2);
            b1.Insert(4);
            Console.WriteLine(b1.Root.Value);
            Console.WriteLine(b1.Root.Left.Value);
            Console.WriteLine(b1.Root.Right.Value);
            // Console.WriteLine();
        }
    }
}
