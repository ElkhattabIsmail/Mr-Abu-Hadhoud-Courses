using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Graph_Representation_and_Conversion
{
    class Program
    {
        class Vertex
        {
            public bool Relation { get; set; }
            public Vertex(bool relation) 
            { 
                Relation = relation; 
            }
        }
        public class AdjacencyList<T>
        {
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
                AllVertices = new Dictionary<T , Dictionary<T, int> >();
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
            /*
             Task:
             Given the following graph, represent it using both adjacency matrix and adjacency list:

            Vertices: A, B, C, D, E
            Edges:
            A -> B
            A -> C
            B -> D
            C -> D
            D -> E
            Questions:
            Create an adjacency matrix to represent the graph.
            Create an adjacency list to represent the same graph.*/
            //int[,] x = new int[2, 3]; initialize 2d Array in c#.

            Vertex[,] matrix = new Vertex[5, 5];
            char C = 'A';
            for (int i = 0; i < 5; i++)
            {
                char C2 = 'A';
                for (int j = 0; j < 5; j++)
                {

                    int R;
                    do
                    {
                        Console.Clear();

                        Console.WriteLine("\tA -> B\n\tA -> C\n\tB -> D\n\tC -> D\n\tD -> E");
                        Console.WriteLine($"\n\t{C}\n");
                        Console.WriteLine($"Is A Relationship Exist between {C} And {C2} ? 0 : false , 1 : True.");
                        R = Convert.ToInt32(Console.ReadLine());
                    } while (R < 0 && R > 1);

                    if (R == 0)
                        matrix[i, j] = new Vertex(false);
                    else
                        matrix[i, j] = new Vertex(true);
                    C2++;
                }
                C++;
            }

            Console.WriteLine($"\nAll RelationShips Between Vertices: \n");
            Console.WriteLine("\t\tA\t\tB\t\tC\t\tD\t\tE\n");
            char C3 = 'A';
            for (int i = 0; i < 5; i++)
            {
                Console.Write(C3);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(("\t\t"));
                    Console.Write(( matrix[i, j].Relation ? 1 : 0));
                }
                C3++;
                Console.WriteLine();
            }


            List<string> Vertices = new List<string>
        {
            {"A" }, {"B"}, {"C"},{"D" } ,{"E" }
        };
            // Adjacency List
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