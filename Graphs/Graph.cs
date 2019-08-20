using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Graph
    {
        Vertex[] matrix; // to add vertex
        int[,] adjMatrix;
        int numVerts;
        int NumOfVert;
        public Graph(int NumOFVert)
        {
            this.NumOfVert = NumOFVert;
            matrix = new Vertex[NumOFVert];
            adjMatrix = new int[NumOFVert, NumOFVert];
            numVerts = 0;

        } 
        public void AddVErtex(int label)
        {
            matrix[numVerts] = new Vertex(label);
            numVerts++;
        }
        public void AddEdge(int source, int destination,int weight)
        {
            adjMatrix[source, destination] = weight;
            adjMatrix[destination, source] = weight;
        }
        public void show()
        {
            Console.WriteLine("My Adjacency Matrix is   ");
            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < adjMatrix.GetLength(1);j++)
                {
                    Console.Write(adjMatrix[i,j]+ " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < adjMatrix.GetLength(0); i++)
            {
                Console.Write($"Vertex {i} is connected to  ");
                for (int j = 0; j < adjMatrix.GetLength(1); j++)
                {
                    if (adjMatrix[i, j] != 0)
                    {
                        Console.Write( $" {j} with weight of {adjMatrix[i,j]}   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
