using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.BFS
{
    class ConnectLevelOrderSiblings
    {
        public static void Connect(TreeNodeLinked root)
        {
            Queue<TreeNodeLinked> queue = new Queue<TreeNodeLinked>();
            int levelSize = 0;
            TreeNodeLinked prevNode = null;

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                levelSize = queue.Count;
                prevNode = null;
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);

                    if(prevNode != null)
                    {
                        prevNode.Next = node;
                    }
                    prevNode = node;
                }
            }
        }

        // Level order traversal using 'next' pointer
        public static void PrintLevelOrder(TreeNodeLinked root)
        {
            TreeNodeLinked nextLevelRoot = root;
            while (nextLevelRoot != null)
            {
                TreeNodeLinked current = nextLevelRoot;
                nextLevelRoot = null;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    if (nextLevelRoot == null)
                    {
                        if (current.Left != null)
                            nextLevelRoot = current.Left;
                        else if (current.Right != null)
                            nextLevelRoot = current.Right;
                    }
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
