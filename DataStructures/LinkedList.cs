using System;

namespace DSA
{
    public class LinkedList
    {
        private LinkedListNode head;
        private LinkedListNode tail;
        private int size;

        public LinkedList(){
            this.size = 0;
        }

        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Size { get; set; }

        public int IncermentSize(){
            this.size += 1;
            return this.size;
        }
        public int DecrementSize(){
            this.size -= 1;
            return this.size;
        }
        // Push: Add to end of LL
        // Pop: Remove from end of LL
        // Insert: Given a value and a position insert a new linked list node of given value at position
        // Delete: Find LL node with given value and delete
        // Traverse: 
        // Reverse: 

    }
}