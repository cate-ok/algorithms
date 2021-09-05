using System.Collections.Generic;

namespace Graphs
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
