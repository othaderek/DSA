using System;
using System.Collections.Generic;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            int num = 6;
            int index = 3;
            ArrayOperations a1 = new ArrayOperations();
            int[] result = a1.InsertBefore(arr, index, num); // [1,2,6,3,4,5]
            Console.Write(a1.PrintArray(result));
        }
    }
}
