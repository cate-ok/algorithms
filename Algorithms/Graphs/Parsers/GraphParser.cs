using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Graphs.Model;

namespace Algorithms.Graphs.Parsers
{
    public class GraphParser : IGraphParser
    {
        public IList<GraphNode<string>> GetStringGraphByString(string[] str)
        {
            // get collection of nodes
            if (str.Length <= 1)
            {
                throw new Exception("Array should have more than one string");
            }

            var nodeValuesStr = str[0];
            var nodes = GetCollectionOfNodes(nodeValuesStr).ToArray();

            // create relationships
            CreateRelationships(str, nodes);

            return nodes;
        }

        private static void CreateRelationships(string[] str, GraphNode<string>[] nodes)
        {
            for (var i = 1; i < str.Length; i++)
            {
                var adjacentsStr = str[i];
                var relations = adjacentsStr.Split(' ').Where(x => x != string.Empty).Select(x => int.Parse(x));
                foreach (var relation in relations)
                {
                    nodes[i - 1].Adjacents.Add(nodes[relation]);
                    nodes[relation].Adjacents.Add(nodes[i - 1]);
                }
            }
        }

        private static IList<GraphNode<string>> GetCollectionOfNodes(string nodeValuesStr)
        {
            var nodeValues = nodeValuesStr.Split(' ');
            var nodes = new List<GraphNode<string>>();
            foreach (var value in nodeValues)
            {
                nodes.Add(new GraphNode<string>(value));
            }

            return nodes;
        }
    }
}
