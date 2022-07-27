
using System;
using System.Collections.Generic;
using data_structures_and_algorithms.HashTable;
using data_structures_and_algorithms.HashTable.Hashmap;
using data_structures_and_algorithms.stack_queue_brackets;


namespace Graphss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);
            Node n9 = new Node(9);
            Node n10 = new Node(10);

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n4, n5);
            graph.AddEdge(n3, n6);
            graph.AddEdge(n1, n6);
            graph.AddEdge(n7, n8);
            graph.AddEdge(n7, n9);
            graph.AddEdge(n1, n10);
            graph.AddEdge(n4, n10);
            graph.AddEdge(n8, n10);
            graph.AddEdge(n3, n10);

            Console.WriteLine($"{n1.Value}'s neighbors: ");
            foreach (Node child in n1.Children)
            {
                Console.WriteLine($"{child.Value}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{n1.Value}'s neighbor with GetNeighbor(): ");
            List<Node> neighbors = graph.GetNeighbor(n1);
            foreach (Node child in neighbors)
            {
                Console.WriteLine($"{child.Value}");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The size of the graph through the Size property");
            Console.WriteLine(graph.Size());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Here is all the nodes in the graph through the GetNodes property");
            foreach (Node node in graph.GetNodes())
            {
                Console.WriteLine($"{node.Value}");
            }

            Console.WriteLine("Here is the breadthfirst traversal");
            List<Node> breadthfirst = graph.BreadthFirst(n1);
            foreach (Node node in breadthfirst)
            {
                Console.WriteLine(node.Value);
            }
            Console.WriteLine();


            Graph graph2 = new Graph();

            Node n11 = new Node("Metroville");
            Node n22 = new Node("Pandora");
            Node n33 = new Node("Arendelle");
            Node n44 = new Node("New Monstropolis");
            Node n55 = new Node("Narnia");
            Node n66 = new Node("Naboo");

            graph2.AddNode("Metroville");
            graph2.AddNode("Pandora");
            graph2.AddNode("Arendelle");
            graph2.AddNode("Narnia");
            graph2.AddNode("New Monstropolis");

            graph2.AddEdge(n11, n22, 150);
            graph2.AddEdge(n22, n33, 99);
            graph2.AddEdge(n33, n55, 82);
            graph2.AddEdge(n2, n44, 105);
            graph2.AddEdge(n11, n55, 26);


            string[] cities = { "Metroville", "Pandora", "Arendelle" };
            var result = graph2.GetEdge(graph2, cities);

            Console.WriteLine($"${result}");
            Console.WriteLine();




            Graph graph1 = new Graph();

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
            Console.Write("Depth first graph: at root A: ");
            foreach (Node node in depthFirst)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();











            //BracketsBalanced stack_Queue_Brackets = new BracketsBalanced();
            //Console.WriteLine("Hello World!");
            //HashTables h = new HashTables(2);
            //h.set("Alaa", 1000);
            //h.set("Omar", 54);
            //Console.Write(h.get("Alaa"));
            //h.keys();
            //hashmap_repeated_word hash = new hashmap_repeated_word();
            //Console.WriteLine("Enter the word!..");
            //string Word = Console.ReadLine();   // Read the Input string from User at Run Time  
            //hash.HashmapRepeatedWord(Word);

            //Console.WriteLine ( "Enter an expression:");
            //string expression = Convert.ToString(Console.ReadLine());
            //if (stack_Queue_Brackets.validatebrackets(expression))
            //    Console.WriteLine("Balanced\n");
            //else
            //    Console.WriteLine("Not Balanced\n");
            //LinkedList list = new LinkedList();
            //list.Append(1);
            //list.Append(2);
            //list.Append(3);
            //list.Append(4);
            ////list.insertLast(5);
            //list.Append(1);
            //list.InsertBefore(60,2);
            //list.Append(7);
            //list.Append(8);
            //list.Append(50);
            //    list.print();

            //list.ReverseList(list);
            //Console.WriteLine("***************");
            //list.print();
            //Console.WriteLine("***************");
            //Console.WriteLine("***************");
            //LinkedList list1 = new LinkedList();
            //list1.Append(1);
            //list1.Append(2);
            //list1.Append(3);
            //list1.Append(4);
            //list1.Append(5);
            //list1.Append(6);
            //Console.WriteLine("***************");
            //LinkedList linkedList = new LinkedList();
            //linkedList.ZipLists(list, list1);
            //linkedList.print();
        }


    }
}


