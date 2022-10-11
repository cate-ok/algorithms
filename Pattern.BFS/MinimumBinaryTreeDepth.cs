using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.BFS
{
    class MinimumBinaryTreeDepth
    {
        // Time O(N) - where N - number of nodes, Space O(N)
        public static int FindDepth(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int levelSize;
            int depth = -1;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                levelSize = queue.Count;
                depth++;

                for (var i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    if (node.Left == null && node.Right == null)
                        return depth;

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }
            return depth;
        }
    }
}
