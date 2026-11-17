using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Program
    {
        public class AdjacencyMatrix<T>
        {
            bool[,] Matrix;
            Dictionary<T, int> Vertices; // Access the index using the vertex
            Dictionary<int, T> reverseVertices; // Access the vertex by its index

            private void PopulateVerticesInDictionary(List<T> vertices)
            {
                for (int i = 0; i < vertices.Count; i++)
                {
                    Vertices.Add(vertices[i], i);
                    reverseVertices.Add(i, vertices[i]);
                }
            }

            public AdjacencyMatrix(List<T> vertices)
            {
                Matrix = new bool[vertices.Count, vertices.Count];
                Vertices = new Dictionary<T, int>();
                reverseVertices = new Dictionary<int, T>();
                PopulateVerticesInDictionary(vertices);
            }

            public void SetEdge(T StartVertex, T EndVertex)
            {
                Matrix[Vertices[StartVertex], Vertices[EndVertex]] = true;
            }

            public void Print()
            {
                PrintVertices();
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    Console.Write(reverseVertices[i] + "   ");
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Console.Write((Matrix[i, j] ? 1 : 0) + " ");
                    }
                    Console.WriteLine();
                }

            }

            public void PrintVertices()
            {
                Console.Write("    ");
                foreach (var item in Vertices)
                {
                    Console.Write(item.Key + " ");
                }
                Console.WriteLine("\n");
            }


        }

        public class AdjacencyList<T>
        {
            //Dictionary<T, int> AdjacentVertices;
            Dictionary<T, Dictionary<T, int>> AllVertices;
            private void PopulateVerticesInDictionary(List<T> vertices)
            {
                for (int i = 0; i < vertices.Count; i++)
                {
                    AllVertices.Add(vertices[i], new Dictionary<T, int>());
                }
            }

            public AdjacencyList(List<T> vertices)
            {
                AllVertices = new Dictionary<T, Dictionary<T, int>>();
                PopulateVerticesInDictionary(vertices);
            }

            public void SetEdge(T startVertex, T endVertex)
            {
                AllVertices[startVertex].Add(endVertex, 1);
            }

            public void print()
            {
                foreach (KeyValuePair<T, Dictionary<T, int>> item in AllVertices)
                {
                    Console.Write(item.Key + " -> ");
                    foreach (KeyValuePair<T, int> v in item.Value)
                    {
                        Console.Write(v.Key + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            //Adjacency Matrix
            List<string> Vertices = new List<string>
        {
            {"A" }, {"B"}, {"C"},{"D" } ,{"E" }
        };

            AdjacencyMatrix<string> adjacencyMatrix = new AdjacencyMatrix<string>(Vertices);
            adjacencyMatrix.SetEdge("A", "B");
            adjacencyMatrix.SetEdge("A", "C");
            adjacencyMatrix.SetEdge("B", "D");
            adjacencyMatrix.SetEdge("C", "D");
            adjacencyMatrix.SetEdge("D", "E");

            adjacencyMatrix.Print();

            Console.WriteLine("\n");
            //Adjacency List
            AdjacencyList<string> ListGraph = new AdjacencyList<string>(Vertices);
            ListGraph.SetEdge("A", "B");
            ListGraph.SetEdge("A", "C");
            ListGraph.SetEdge("B", "D");
            ListGraph.SetEdge("C", "D");
            ListGraph.SetEdge("D", "E");

            ListGraph.print();

        }

    }
}