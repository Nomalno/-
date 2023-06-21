using kursa4;
using System;

using System;
using System.Linq;




class Program
{
    static void Main()
    {
        int V = 4, E = 5;
        Graph graph = new Graph(V, E);
        graph.AddEdge(0, 1, 10, 0);
        graph.AddEdge(0, 2, 6, 1);
        graph.AddEdge(0, 3, 5, 2);
        graph.AddEdge(1, 3, 15, 3);
        graph.AddEdge(2, 3, 4, 4);

        graph.KruskalMST();
    }
}