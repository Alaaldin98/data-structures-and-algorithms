using System;
using Xunit;
using Graph;
using System.Collections.Generic;

namespace GraphTest
{
    public class graphdepthfirstTest
    {
        [Fact]
        public void test_bfs()
        {
            Graphs graph = new Graphs();
            Node one = graph.addNode(1);
            Node two = graph.addNode(2);
            Node three = graph.addNode(2);

            one.addNeighbor(two);
            one.addNeighbor(three);

            List<Node> expected = new List<Node>();
            expected.Add(one);
            expected.Add(three);
            expected.Add(two);

            Assert.Equal(expected, graph.Depthfirst(one));
        }
    }
}
