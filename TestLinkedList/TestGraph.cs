using Graphss;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestGraph
{
    public class UnitTest1
    {
        [Fact]
        public void DepthFirstTest()
        {
            Graph graph = new Graph();

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node H = new Node("H");

            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("H");

            graph.AddEdge(A, B, 150);
            graph.AddEdge(A, D, 99);
            graph.AddEdge(B, C, 82);
            graph.AddEdge(B, D, 105);
            graph.AddEdge(D, F, 26);
            graph.AddEdge(D, H, 10);
            graph.AddEdge(D, E, 13);
            graph.AddEdge(F, H, 15);

            List<Node> depthFirst = graph.DepthFirst(graph);
            List<Object> result = new List<object>();
            foreach (var item in depthFirst)
            {
                result.Add(item.Value);
            }
            List<Object> expected = new List<Object> { "A", "B", "C", "D", "F", "H", "E" };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DepthFirstEmptyTest()
        {
            Graph graph = new Graph();

            List<Node> result = graph.DepthFirst(graph);

            Assert.Null(result);
        }
    }
    public class UnitTest2
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Graph graph = new Graph();

            // Act
            graph.AddEdge(n1, n2);

            // Assert
            Assert.Equal(n2, n1.Children[0]);
        }
        [Fact]
        public void SizeTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            Graph graph = new Graph();

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n3, n5);

            // Act
            int size = graph.Size();

            // Assert
            Assert.Equal(5, size);
        }
        [Fact]
        public void GetNeighborsTest()
        {
            // Arrange
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            Graph graph = new Graph();

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n3, n5);

            // Act
            List<Node> neighbors = graph.GetNeighbor(n2);

            // Assert
            Assert.Equal(1, neighbors[0].Value);
            Assert.Equal(4, neighbors[1].Value);
        }
    }
    public class UnitTest3
    {
        [Fact]
        public void GetEdgeTest()
        {
            Graph graph2 = new Graph();

            Node n1 = new Node("Metroville");
            Node n2 = new Node("Pandora");
            Node n3 = new Node("Arendelle");
            Node n4 = new Node("New Monstropolis");
            Node n5 = new Node("Narnia");
            Node n6 = new Node("Naboo");

            graph2.AddNode("Metroville");
            graph2.AddNode("Pandora");
            graph2.AddNode("Arendelle");
            graph2.AddNode("Narnia");
            graph2.AddNode("New Monstropolis");

            graph2.AddEdge(n1, n2, 150);
            graph2.AddEdge(n2, n3, 99);
            graph2.AddEdge(n3, n5, 82);
            graph2.AddEdge(n2, n4, 105);
            graph2.AddEdge(n1, n5, 26);

            string[] cities = { "Metroville", "Pandora", "Arendelle" };
            var result = graph2.GetEdge(graph2, cities);
            Assert.Equal(249, result);
        }

    }
}