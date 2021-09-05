using Graphs;
using Graphs.Parsers;
using System.Collections.Generic;
using Xunit;

namespace GraphsTest
{
    public class GraphParserTest
    {
        [Fact]
        public void GetGraphWithParser()
        {
            var filePath = "C:\\code\\Algorithms\\GraphsTest\\input2.txt";
            GraphParser gp = new GraphParser();
            List<Node> graph = gp.Parse(filePath);

            var expected = 5;
            var actual = graph.Count;
            Assert.Equal(expected, actual);
        }
    }
}
