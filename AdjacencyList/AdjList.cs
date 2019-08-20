using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList
{
    class AdjList
    {
        int vertex;
        LinkedList<int> [] list;

        public AdjList(int vertex)
        {
            this.vertex = vertex;
            list = new LinkedList<int>[vertex];
            for (int i = 0; i < vertex; i++)
            {
                list[i] = new LinkedList<int>();  // creating new list
            }
        }
        public void AddEdge(int source, int destination)
        {
            list[source].AddFirst(destination);
            list[destination].AddFirst(source);
        }
        public void show()
        {
            for (int i = 0; i < list.Length; i++)
            {
               
                if (list[i].Count > 0)
                {
                    Console.Write($"Vertex {i} is coneected to  :");
                    foreach (var item in list[i])
                    {
                        Console.Write(item + " ");
                    }

                   
                }
                Console.WriteLine();
            }
        }

    }
}
