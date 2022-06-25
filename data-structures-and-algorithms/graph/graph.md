# Graphs
A Graph is a non-linear data structure consisting of nodes and edges. The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph.

A Graph consists of a finite set of vertices(or nodes) and set of Edges which connect a pair of nodes.

## Challenge
 Graph implementation with folloing methods :

- AddNode

- AddEdge

- GetNodes

- GetNeighbors

- Size

## Approach & Efficiency
|  Method   | 	Time Complexity  | 	Space Complexity  |
|  -------  |  ----------        |  -------   |
|  AddNode	| O(1)  |	O(1)  | 
|  AddEdge	|  O(1)  | 	O(1)  |
GetNodes  |	O(n)  | 	O(n)
GetNeighbors  |	O(n)  |	O(1)
Size  |	O(1)  |	O(1)

## API

1. AddNode()
- Adds a node to the graph.

2. AddEdge()
- Adds an edge to a node which connects to another node or itself, and includes a weight value.

3. GetNodes()
- Returns a list of nodes within the graph.

4. GetNeighbors()
- Returns a list of neighbors of a given node, including the weight of each edge between them.

5. Size()
- Returns a count of all the nodes in a graph.