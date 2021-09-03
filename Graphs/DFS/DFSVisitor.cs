using System;
using System.Collections.Generic;

namespace Algorithms.Graphs.DFS
{
    public abstract class DFSVisitor<T>
    {
        private List<GraphNode<T>> visited = new List<GraphNode<T>>();

        private bool result = false;

        public void Visit(GraphNode<T> node)
        {
            this.result = this.VisitNode(node);
            this.visited.Add(node);

            foreach (var child in node.Adjacents)
            {
                if (this.result)
                {
                    return;
                }

                if (!this.visited.Contains(child))
                {
                    this.Visit(child);
                }
            }

        }

        protected abstract bool VisitNode(GraphNode<T> node);
    }
}
