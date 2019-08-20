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
            var myCar = new { Color = "Blue", Make = "BMW", Amount = 2000 };
            Graph graph = new Graph(6);
            graph.AddEdge(1, 2,11);
            graph.AddEdge(3, 4,56);
            graph.AddEdge(5, 4,43);
            graph.AddEdge(3, 5,65);          // the egdges (a,b) can take V(V - 1)/ 2. im working with bidirectional graph i.e up to 15 edges
            graph.AddEdge(0, 1,50);
            graph.AddEdge(1, 2,60);
            graph.AddVErtex(2);
            graph.AddVErtex(3);
            graph.show();
            Console.WriteLine(myCar.Color);
            Console.ReadKey();
        }
    }
}
