using System;

namespace DSA
{
    public class LinkedListNode
    {

        public LinkedListNode(string hashCode, int val){
            Key = hashCode;
            Value = val;
            Next = null;
        }
        public string Key { get; set; }
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }
    }
}