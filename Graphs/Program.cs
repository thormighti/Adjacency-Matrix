using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph(6);
            graph.AddEdge(1, 2);
            graph.AddEdge(3, 4);
            graph.AddEdge(5, 4);
            graph.AddEdge(3, 5);          // the egdges (a,b) can take V(V - 1)/ 2. im working with bidirectional graph i.e up to 15 edges
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddVErtex(2);
            graph.AddVErtex(3);
            graph.show();
           
            Console.ReadKey();
        }
    }
}
