//using data_structures_and_algorithms.graph;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace TestLinkedList
//{
//    public class TestGraph
//    {
//        [Fact]
//        public void TestDepthFirst1()
//        {
//            var vertex = graph.AddNode("A");
//            var vertex1 = graph.AddNode("B");
//            var vertex2 = graph.AddNode("C");
//            var vertex3 = graph.AddNode("D");


//            graph.AddEdge(vertex, vertex3, 10);
//            graph.AddEdge(vertex, vertex1, 10);

//            graph.AddEdge(vertex1, vertex3, 10);
//            graph.AddEdge(vertex1, vertex2, 10);


//            List<Vertex> list = graph.DepthFirst(vertex);
//            List<Vertex> expected = new List<Vertex> { vertex, vertex3, vertex1, vertex2 };
//            Assert.Contains(expected[2], list);
//        }
//        [Fact]
//        public void TestDepthFirst2()
//        {
//            var vertex = graph.AddNode("A");
//            List<Vertex> result = graph.DepthFirst(vertex);
//            Assert.Equal("A", result[0].value);
//        }
//        [Fact]
//        public void TestDepthFirst3()
//        {
//            var vertex = graph.AddNode("A");
//            graph.AddEdge(vertex, vertex, 1);
//            List<Vertex> result = graph.DepthFirst(vertex);
//            Assert.Equal("A", result[0].edges[0].getEnd().value);
//        }
//    }
//}
