using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.BFS
{
    class ReverseLevelOrderTraversal
    {
        // Time O(N) - where N - number of nodes, Space O(N)
        public static List<List<int>> Traverse(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int levelSize;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> myList = new List<int>();
                levelSize = queue.Count;

                for(var i = 0; i< levelSize; i++)
                {
                    var node = queue.Dequeue();
                    myList.Add(node.Value);

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
                result.Insert(0, myList);
            }
            return result;
        }
    }
}
