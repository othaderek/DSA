using System;

namespace DSA
{
    public class LinkedListNode
    {
        private LinkedListNode next;

        public LinkedListNode(int val){
            Value = val;
            Next = null;
        }
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }
    }
}