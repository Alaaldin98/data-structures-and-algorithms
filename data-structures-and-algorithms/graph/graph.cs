using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.graph
{
    public class graph
    {
        private List<Vertex> vertices;
        private bool isWeighted;
        private bool isDirected;
        public graph(bool inputIsWeighted, bool inputIsDirected)
        {
            this.vertices = new List<Vertex>();
            this.isWeighted = inputIsWeighted;
            this.isDirected = inputIsDirected;
        }
        public Vertex AddNode(int val)
        {
            Vertex newvertex = new Vertex(val);
            vertices.Add(newvertex);
            return newvertex;
        }
        public void AddEdge(Vertex vertex1, Vertex vertex2, int weight)
        {
            if (!this.isWeighted)
            {
                weight = (int)(int?)null;
            }
            vertex1.addEdge(vertex2, weight);
            if (!this.isDirected)
            {
                vertex2.addEdge(vertex1, weight);
            }
        }
        public List<Vertex> GetNodes()
        {
            if (vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return vertices;

            }
        }
        public List<Edge> GetNeighbors(Vertex node)
        {
            return vertices.Find(v => v.value == node.value).edges;
        }
        public int Size()
        {
            return vertices.Count;
        }

        public void PrintGraph(List<int>[] adj, int V)
        {
            for (int v = 0; v < V; ++v)
            {
                Console.Write("vertex " + v + " ");
                foreach (int x in adj[v])
                    Console.Write("-> " + x);
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public List<Vertex> BreadthFirst(Vertex vertex)
        {
            List<Vertex> visitedVertices = new List<Vertex>();
            Queue<Vertex> visitQueue = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            visitQueue.Enqueue(vertex);
            visited.Add(vertex);
            if (visitQueue.Count == 0)
            {
                throw new Exception("no nodes added");
            }
            while (visitQueue.Count != 0)
            {
                Vertex front = visitQueue.Dequeue();
                visitedVertices.Add(front);
                foreach (Edge child in ((Vertex)front).edges)
                {
                    Vertex neighbor = child.getEnd();
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        visitQueue.Enqueue(neighbor);
                    }
                }
            }
            return visitedVertices;
        }
    }
    public class Vertex
    {
        public int value { get; set; }
        public List<Edge> edges;

        public Vertex(int value)
        {
            this.value = value;
            this.edges = new List<Edge>();
        }
        public void addEdge(Vertex endVertex, int weight)
        {
            this.edges.Add(new Edge(this, endVertex, weight));
        }
    }
    public class Edge
    {
        private Vertex start;
        private Vertex end;
        private int weight;
        private Node node;

        public Edge(Vertex startV, Vertex endV, int inputWeight)
        {
            this.start = startV;
            this.end = endV;
            this.weight = inputWeight;
        }

        public Edge(Node node)
        {
            this.node = node;
        }

        public Vertex getStart()
        {
            return this.start;
        }

        public Vertex getEnd()
        {
            return this.end;
        }

        public int getWeight()
        {
            return this.weight;
        }
    }
}
