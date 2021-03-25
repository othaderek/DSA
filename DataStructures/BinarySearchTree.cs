using System;
using System.Collections.Generic;

namespace DSA
{
    public class BinarySearchTree {

        public BSTNode Root { get; set; }
        public int Size { get ; set; }

        public BinarySearchTree(){
            Root = null;
            Size = 0;
        }
        public void IncrementSize(){
            this.Size += 1;
        }

        public BinarySearchTree Insert(int val){
            BSTNode newNode = new BSTNode(val);
            if (this.Root == null){
                this.Root = newNode;
                return this;
            }
            BSTNode currentNode = this.Root;
            while (true){
                if (val < currentNode.Value){
                    if (currentNode.Left == null){
                        currentNode.Left = newNode;
                        return this;
                    }
                    currentNode = currentNode.Left;
                } else {
                    if (currentNode.Right == null){
                        currentNode.Right = newNode;
                        return this;
                    }
                    currentNode = currentNode.Right;
                }
            }
        }

        public List<int> DFS(){
            List<int> visited = new List<int>();
            BSTNode current = this.Root;

            void Traverse(BSTNode node){
                if (node.Left != null) Traverse(node.Left);
                visited.Add(node.Value);
                if (node.Right != null) Traverse(node.Right);
            }
            Traverse(current);
            return visited;
        }

        public string PrintTree(List<int> result){
            string nodes = result[0].ToString();
            for ( int i = 1; i < result.Count; i++){
                nodes += $", {result[i].ToString()}";
            }
            return nodes;
        }

        public List<int> BFS(){
            
        }
        // insert
        // bfs
        // dfs (in order, preorder, postorder)
        // find
    }
}