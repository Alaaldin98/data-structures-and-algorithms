using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.graph.graphbreadthfirst
{
    internal class graph_breadth_first
    {
        public List<Vertex> BreadthFirst(Vertex node)
        {
            List<Vertex> visitedVertices = new List<Vertex>();
            Queue<Vertex> visitQueue = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            visitQueue.Enqueue(node);
            visited.Add(node);
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
}
