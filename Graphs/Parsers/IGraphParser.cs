using System.Collections.Generic;

namespace Graphs.Parsers
{
    public interface IGraphParser
    {
        List<Node> Parse(string source);
    }
}
