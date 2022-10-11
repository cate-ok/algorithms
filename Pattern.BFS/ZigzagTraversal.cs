using System;
using System.Collections.Generic;

namespace Pattern.BFS
{
    class ZigzagTraversal
    {
        // Time O(N) - where N - number of nodes, Space O(N)
        public static List<List<int>> Traverse(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int levelSize;
            bool fromLeft = true;
            
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                levelSize = queue.Count;
                List<int> myList = new List<int>();

                for (var i = 0; i<levelSize; i++)
                {
                    var node = queue.Dequeue();
                    if (fromLeft)
                    {
                        myList.Add(node.Value);
                    }
                    else
                    {
                        myList.Insert(0, node.Value);
                    }

                    if (node.Left != null)
                        queue.Enqueue(node.Left);

                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }

                fromLeft = !fromLeft;
                result.Add(myList);
            }
            return result;
        }
    }
}
