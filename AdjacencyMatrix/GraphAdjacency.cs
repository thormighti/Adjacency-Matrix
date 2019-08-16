using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    class GraphAdjacency
    {
       // int size;
        
        List<int> [] list;
        public GraphAdjacency(int size)
        {
          
           
            list = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                list[i] = new List<int>();
            }
        }
        public void AddEdge(int source , int destination)
        {
            
            list[source].Add(destination);
           // list[destination].Add(source);   // undirected graph
        }
        public bool HasEdge(int source, int destination)
        {
            bool hasEdge = list[source].Contains(destination);
            return hasEdge;
        }
        public void printOut()
        {
           for(int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (adj[i, j])
                    {
                        Console.Write(1.ToString() + " ");
                    }
                    else
                    {
                        Console.Write(6.ToString() + " ");
                    }
                }
               
                Console.WriteLine();
            }
        }   
    }
}
