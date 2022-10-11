using System;
using System.Collections.Generic;

namespace Pattern.BFS
{
    class LevelAverages
    {
        // Time O(N) - where N - number of nodes, Space O(N)
        public static List<double> FindAverages(TreeNode root)
        {
            List<double> result = new List<double>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int levelSize;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                levelSize = queue.Count;
                double sum = 0;

                for (var i = 0; i<levelSize; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.Value;

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                    
                }
                result.Add(sum/levelSize);
            }
            return result;
        }
    }
}
