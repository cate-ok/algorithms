using System;
using System.Collections.Generic;
using System.IO;

namespace Graphs.Parsers
{
    public class GraphParser : IGraphParser
    {
        public List<Node> Parse(string source)
        {
            List<Node> graph = new List<Node>();
            StreamReader sr = new StreamReader(source);
            int nodesCount = Int32.Parse(sr.ReadLine());

            for (var i = 0; i < nodesCount; i++)
            {
                string[] str = sr.ReadLine().Split(" ");
                char character = char.Parse(str[0]);
                int adjCount = Int32.Parse(str[1]);

                Node u = new Node(character);
                for(var j=0; j< adjCount; j++)
                {
                    char letter = char.Parse(sr.ReadLine());
                    Node v = GetNode(graph, letter);
                    if (v == null)
                        v = new Node(letter);
                    u.Adjacents.Add(v);
                }

                graph.Add(u);
            }
            sr.Close();
            return graph;
        }

        private static Node GetNode(List<Node> graph, char data)
        {
            for (var i = 0; i < graph.Count; i++)
            {
                if (graph[i].Data == data)
                {
                    return graph[i];
                }
            }
            return null;
        }
    }
}
