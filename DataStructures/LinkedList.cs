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

        }
        // Insert: Given a value and a position insert a new linked list node of given value at position
        public void Insert(int val){

        }
        // Delete: Find LL node with given value and delete
        public void Delete(int val){

        }
        // Traverse:
        public LinkedListNode[] Traverse(){
            LinkedListNode[] allNodes = {};
            return allNodes;
        }
        // Reverse: 
        public LinkedListNode[] Reverse(){
            LinkedListNode[] reversedNodes = {};
            return reversedNodes;
        }

    }
}