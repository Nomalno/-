using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4;
class Graph
{
    int V, E;
    Edge[] edges;

    public Graph(int v, int e)
    {
        V = v;
        E = e;
        edges = new Edge[E];
    }

    public void AddEdge(int u, int v, int w, int index)
    {
        edges[index] = new Edge(u, v, w);
    }

    public void KruskalMST()
    {
        Edge[] result = new Edge[V];
        int[] parent = new int[V];

        for (int z = 0; z < V; z++)
            parent[z] = z;

        int e = 0;
        int i = 0;

        Array.Sort(edges);

        while (e < V - 1 && i < E)
        {
            Edge edge = edges[i++];
            int x = Find(parent, edge.U);
            int y = Find(parent, edge.V);

            if (x != y)
            {
                result[e++] = edge;
                Union(parent, x, y);
            }
        }

        Console.WriteLine("Древа в МОД:");
        for (i = 0; i < e; ++i)
            Console.WriteLine(result[i].U + " - " + result[i].V + ": " + result[i].Weight);
    }

    int Find(int[] parent, int i)
    {
        if (parent[i] == i)
            return i;

        return parent[i] = Find(parent, parent[i]);
    }

    void Union(int[] parent, int x, int y)
    {
        int rootX = Find(parent, x);
        int rootY = Find(parent, y);

        parent[rootX] = rootY;
    }
}