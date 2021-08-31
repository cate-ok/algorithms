using System.Collections.Generic;

namespace Algorithms.Graphs.Model
{
    public class GraphNode<T>
    {
        public T Data { get; set; }
        public IList<GraphNode<T>> Adjacents { get; set; }

        public GraphNode(T data)
        {
            this.Data = data;
            this.Adjacents = new List<GraphNode<T>>();
        }
    }
}