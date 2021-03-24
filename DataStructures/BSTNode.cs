using System;

namespace DSA
{
    public class BSTNode {

        public BSTNode(int val){
            Value = val;
            Left = null;
            Right = null;
        }

        public int Value { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
    }
}