using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    class Edge : IComparable<Edge>
    {
        public int U, V, Weight;

        public Edge(int u, int v, int weight)
        {
            U = u;
            V = v;
            Weight = weight;
        }

        public int CompareTo(Edge edge)
        {
            return Weight - edge.Weight;
        }
    }
}
