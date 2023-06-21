

using ConsoleApp1;

class Program
{
    static void Main()
    {
        int V = 4;
        Graph graph = new Graph(V);
        graph.AddEdge(0, 1, 10);
        graph.AddEdge(0, 2, 6);
        graph.AddEdge(0, 3, 5);
        graph.AddEdge(1, 3, 15);
        graph.AddEdge(2, 3, 4);

        graph.PrimMST();
    }
}