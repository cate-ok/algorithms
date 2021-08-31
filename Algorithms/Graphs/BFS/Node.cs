using System.Collections.Generic;

namespace Algorithms.Graphs.BFS
{
    public class Node
    {
        public char Data { get; set; }
        public List<Node> Adjacents { get; set; }

        public Node(char data)
        {
            Data = data;
            Adjacents = new List<Node>();
        }
    }
}
