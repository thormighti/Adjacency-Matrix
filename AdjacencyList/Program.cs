using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjList list = new AdjList(6);
            list.AddEdge(1, 3);
            list.AddEdge(2, 4);
            list.AddEdge(1, 5);
            list.AddEdge(5, 4);
            list.AddEdge(2, 5);

            list.show();
            Console.ReadKey();
        }
    }
}
