using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs.BFS
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
            Dictionary<char, int> pathLength = new Dictionary<char, int>();
            Dictionary<char, Node> parents = new Dictionary<char, Node>();
            foreach (var node in graph)
            {
                if (node.Data != endChar)
                    pathLength.Add(node.Data, 0);
                parents.Add(node.Data, null);
            }

            visited[start.Data] = true;
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();   // v
                if (node.Data == endChar)
                {
                    return pathLength[node.Data];
                }
                for (var i = 0; i < node.Adjacents.Count; i++)
                {
                    Node toNode = node.Adjacents[i];
                    if (!visited[toNode.Data])
                    {
                        visited[toNode.Data] = true;
                        queue.Enqueue(toNode);

                        pathLength[toNode.Data] = pathLength[node.Data] + 1;
                        parents[toNode.Data] = node;

                        //d[to] = d[v] + 1;  //pathLength
                        //p[to] = v;  //parents
                    }
                }
            }
            return -1;
        }
    }
}
