﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Edge
    {
        public int weight;
        public Node node;


        public Edge(Node node)
        {
            this.node = node;
        }

        public Edge(Node node, int weight)
        {
            this.node = node;
            this.weight = weight;
        }

        public Node getNode()
        {
            return node;
        }
    }
    public class Node
    {
        public int data;
        public HashSet<Edge> neighbors;

        public Node(int data)
        {
            this.data = data;
            neighbors = new HashSet<Edge>();
        }
        public void addNeighbor(Node node)
        {
            Edge edge = new Edge(node);
            neighbors.Add(edge);
        }
    }
    public class Graphs
    {
        public HashSet<Node> vertices;

        public Graphs()
        {
            vertices = new HashSet<Node>();
        }

        public Node addNode(int data)
        {
            Node node = new Node(data);
            vertices.Add(node);
            return node;
        }

        public bool addEdge(Node source, Node destination)
        {
            if (vertices.Contains(source) && vertices.Contains(destination))
            {
                this.vertices.Add(source);
                this.vertices.Add(destination);
                return true;
            }
            return false;
        }

        public void getEdges(String[] input)
        {

        }

        public HashSet<Node> getNodes()
        {
            return this.vertices;
        }

        public HashSet<Edge> getNeighbors(Node node)
        {
            return node.neighbors;
        }

        public int getSize()
        {
            return this.vertices.Count();
        }

        public List<Node> Depthfirst(Node start)
        {
            List<Node> result = new List<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            Stack stack = new Stack();
            stack.Push(start);
            visited.Add(start);

            while (stack.Count > 0)
            {
                Node tempNode = (Node)stack.Pop();
                result.Add(tempNode);

                foreach (var neighbor in tempNode.neighbors)
                {
                    if (!visited.Contains(neighbor.node))
                    {
                        stack.Push(neighbor.node);
                        visited.Add(neighbor.node);
                    }
                }
            }
            return result;
        }

      
    }
}