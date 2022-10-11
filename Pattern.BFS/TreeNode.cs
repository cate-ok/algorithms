using System;

namespace Pattern.BFS
{
    class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int x)
        {
            Value = x;
        }
    }
}
