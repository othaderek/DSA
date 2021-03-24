using System;

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

        public int[] DFS(BSTNode root){
            int[] nodeArr = new int[this.Size];
        }

        public string PrintTree(int[] result){

            return "";
        }
        // insert
        // bfs
        // dfs (in order, preorder, postorder)
        // find
    }
}