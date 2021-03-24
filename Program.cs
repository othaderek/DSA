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
            b1.Insert(1);
            b1.Insert(5);
            List<int> nodes = b1.DFS();
            Console.WriteLine(b1.PrintTree(nodes));
        }
    }
}
