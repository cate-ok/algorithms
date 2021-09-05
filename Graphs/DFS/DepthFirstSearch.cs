using System.Collections.Generic;

namespace Graphs.DFS
{
    public class DepthFirstSearch
    {
        private int time;                     // step
        Dictionary<char, NodeColor> visited;  // color: 0 - white, 1 - grey, 2 - black
        Dictionary<char, Node> p;  // parents

        Dictionary<char, int> timeDiscovered; // u.d
        Dictionary<char, int> timeFinished;   // u.f

        public void Search(List<Node> graph)
        {
            visited = new Dictionary<char, NodeColor>();
            p = new Dictionary<char, Node>();
            timeDiscovered = new Dictionary<char, int>();
            timeFinished = new Dictionary<char, int>();

            foreach (var u in graph)
            {
                visited.Add(u.Data, NodeColor.White);
                p.Add(u.Data, null);
                timeDiscovered.Add(u.Data, -1);
                timeFinished.Add(u.Data, -1);
            }
            time = 0;
            foreach (var u in graph)
            {
                if (visited[u.Data] == NodeColor.White)
                    DFSVisit(graph, u);
            }
        }

        private void DFSVisit(List<Node> graph, Node u)
        {
            time++;
            timeDiscovered[u.Data] = time;    // u.d
            visited[u.Data] = NodeColor.Grey; // u.color

            foreach (var v in u.Adjacents)
            {
                if (visited[u.Data] == NodeColor.White)
                {
                    p[v.Data] = u;
                    DFSVisit(graph, v);
                }
            }

            visited[u.Data] = NodeColor.Black;
            time++;
            timeFinished[u.Data] = time;
        }
    }
}
