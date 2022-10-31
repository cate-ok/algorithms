using System;
using System.Collections.Generic;

namespace Pattern.BFS
{
    class LevelOrderSuccessor
    {
        // 
        public static TreeNode FindSuccessor(TreeNode root, int key)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);

                if (node.Value == key)
                {
                    break;
                }
            }
            return queue.Peek();
        }
    }
}
