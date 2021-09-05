using System.Collections.Generic;

namespace Graphs
{
    public class GraphNode<T>
    {
        public T Data { get; set; }
        public List<GraphNode<T>> Adjacents { get; set; }

        public GraphNode(T data)
        {
            Data = data;
            Adjacents = new List<GraphNode<T>>();
        }
    }
}
