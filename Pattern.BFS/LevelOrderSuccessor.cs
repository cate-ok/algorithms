using System;
using System.Collections.Generic;

namespace Pattern.BFS
{
    class LevelOrderSuccessor
    {
        // 
        public static TreeNode FindSuccessor(TreeNode root, int key)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int levelSize;
            
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                levelSize = queue.Count;
                List<int> myList = new List<int>();

                for (var i = 0; i<levelSize; i++)
                {
                    var node = queue.Dequeue();
                    myList.Add(node.Value);

                    if (node.Left != null)
                        queue.Enqueue(node.Left);

                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                    
                }
                result.Add(myList);
            }
            return null;
        }
    }
}
