using System;

namespace DSA
{
    public class LinkedList
    {

        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Size { get; set; }

        public void IncrementSize() => this.Size += 1;
        public void DecrementSize() => this.Size -= 1;

        public void Push(int val){
            // Check if there is a head
            // If there is no head add new node to head and tail increment ll
            // If there is already a head then set ll node to next of the tail and then reset tail to newNode
            LinkedListNode newNode = new LinkedListNode(val);
            if (this.Size == 0)
            {
                this.Head = newNode;
                this.Tail = newNode;
                this.IncrementSize();
                return;
            }
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.IncrementSize();
        }
        // Push: Add to end of LL
        // Pop: Remove from end of LL
        // Insert: Given a value and a position insert a new linked list node of given value at position
        // Delete: Find LL node with given value and delete
        // Traverse: 
        // Reverse: 

    }
}