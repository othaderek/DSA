using System;

namespace DSA
{
    public class HashTable
    {
        public int bucketCount = 10;
        public LinkedList[] linkedList = new LinkedList[10];

        public LinkedList[] GetLinkedListsArray(){
            return this.linkedList;
        }

        public LinkedList[] AddLLToHashTable(int index){
            this.linkedList[index] = new LinkedList();
            return this.linkedList;
        }

        public LinkedList[] PopulateLLArray(){
            for (var i = 0; i <= 10; i++)
            {
                AddLLToHashTable(i);
            }
            return this.GetLinkedListsArray();
        }

        // public LinkedList[] AddNode
        // Use array of linked lists
        // Generate hash key with built in hashing function stringvalue.GetHashCode()
        // Create new linked list nodes and add them to linked list method
    }
}
