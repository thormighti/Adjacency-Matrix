using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<long, int> pii;
            
            GraphAdjacency graph = new GraphAdjacency(10);
            graph.AddEdge(3, 4);
            graph.AddEdge(1,2);
            graph.AddEdge(5,6);
            graph.AddEdge(7,8);
            graph.AddEdge(9, 3);
            graph.printOut( );
            Console.WriteLine( graph.HasEdge(6,5));
            Console.ReadKey();
        }
    }
}
