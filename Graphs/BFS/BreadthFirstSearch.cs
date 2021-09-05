using System;
using System.Collections.Generic;

namespace Graphs.BFS
{
    public class BreadthFirstSearch
    {
        private static int GetMinPath(List<Node> graph, Node start, char endChar)
        {
            if (start.Data == endChar)
                return 0;

            Dictionary<char, bool> visited = new Dictionary<char, bool>();
            foreach (var node in graph)
                visited.Add(node.Data, false);  // mark all nodes as not visited
            Queue<Node> queue = new Queue<Node>();
            Dictionary<char, int> d = new Dictionary<char, int>();  //pathLength
            Dictionary<char, Node> parents = new Dictionary<char, Node>();
            foreach (var node in graph)
            {
                if (node.Data != endChar)
                    d.Add(node.Data, 0);           //pathLength
                parents.Add(node.Data, null);      // no parent
            }

            visited[start.Data] = true;
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();   // u
                if (node.Data == endChar)
                {
                    return d[node.Data];
                }
                for (var i = 0; i < node.Adjacents.Count; i++)
                {
                    Node toNode = node.Adjacents[i];   // v
                    if (!visited[toNode.Data])
                    {
                        visited[toNode.Data] = true;
                        queue.Enqueue(toNode);

                        d[toNode.Data] = d[node.Data] + 1;
                        parents[toNode.Data] = node;
                    }
                }
            }
            return -1;
        }
    }
}
