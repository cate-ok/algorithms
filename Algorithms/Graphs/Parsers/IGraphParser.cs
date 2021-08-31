using System.Collections.Generic;
using Algorithms.Graphs.Model;

namespace Algorithms.Graphs.Parsers
{
    public interface IGraphParser
    {
        IList<GraphNode<string>> GetStringGraphByString(string[] str);
    }
}
