using System;
using System.Collections.Generic;

namespace DSA
{
    public class LinkedList
    {

        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Size { get; set; }

        public void IncrementSize() => this.Size += 1;
        public void DecrementSize() => this.Size -= 1;

        // Push: Add to end of LL
        // Check if there is a head
        // If there is no head add new node to head and tail increment ll
        // If there is already a head then set ll node to next of the tail and then reset tail to newNode
        public void Push(int val){
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
        // Pop: Remove from end of LL
        public void Pop(){
            // Remove the tail
            // Loop through the entire Linked List
            // Keep track of previous node
            // Traverse LL previous node to the new tail 
            // Set the new tails value to null
            if (this.Head == null){
                Console.WriteLine("This is an empty Linked List.");
                return;
            }
            LinkedListNode current = this.Head;
            LinkedListNode previous = null;
            while (current.Next != null){
                previous = current;
                current = current.Next;
                Console.WriteLine($"Current val: {current.Value.ToString()}");
            }
            previous.Next = null;
            this.Tail = previous;
            this.DecrementSize();
        }
        // Insert: Given a value and a position insert a new linked list node of given value at position
        public void Insert(int val){

        }
        // Delete: Find LL node with given value and delete
        public void Delete(int val){

        }
        public List<int> LinkedListValues(){
            List<int> allNodes = new List<int>();
            if (this.Size == 0) return allNodes;
            LinkedListNode current = this.Head;
            while (current != null)
            {
                allNodes.Add(current.Value);
                current = current.Next;
            }
            return allNodes;
        }
        // Traverse:
        public List<LinkedListNode> Traverse(){
            List<LinkedListNode> allNodes = new List<LinkedListNode>();
            if (this.Size == 0) return allNodes;
            return allNodes;
        }
        // Reverse: 
        public List<LinkedListNode> Reverse(){
            List<LinkedListNode> reversedNodes = new List<LinkedListNode>();
            return reversedNodes;
        }

    }
}