using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Graph
    {
        int V;
        int[,] graph;

        public Graph(int v)
        {
            V = v;
            graph = new int[V, V];

            for (int i = 0; i < V; i++)
                for (int j = 0; j < V; j++)
                    graph[i, j] = 0;
        }

        public void AddEdge(int u, int v, int w)
        {
            graph[u, v] = w;
            graph[v, u] = w;
        }

        public void PrimMST()
        {
            int[] parent = new int[V];
            int[] key = new int[V];
            bool[] mstSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinimumKey(key, mstSet);

                mstSet[u] = true;

                for (int v = 0; v < V; v++)
                {
                    if (graph[u, v] != 0 && mstSet[v] == false && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
                }
            }

            Console.WriteLine("Edges in the MST:");
            for (int i = 1; i < V; i++)
                Console.WriteLine(parent[i] + " - " + i + ": " + graph[i, parent[i]]);
        }

        int MinimumKey(int[] key, bool[] mstSet)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < V; v++)
            {
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
    }
}
