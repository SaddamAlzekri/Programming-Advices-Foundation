using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

public class Graph
{
    public enum enGraphType { Directed,  Undirected }

    int[,] adjancecyMatrix;
    
    private int NumberOfVectors = 0;

    private Dictionary<string, int> GraphVectors;

    private enGraphType enGraphType1 = enGraphType.Directed;
    public Graph(List<string> Vectors,enGraphType enGraphType)
    {
        this.enGraphType1 = enGraphType;

        NumberOfVectors = Vectors.Count;

        adjancecyMatrix = new int[NumberOfVectors, NumberOfVectors];

        GraphVectors = new Dictionary<string, int>();

        for(int i = 0; i < NumberOfVectors; i++)
        {
            GraphVectors[Vectors[i]] = i;
        }
    }

    public void AddEdge(string Source, string Destintion, int Wight)
    {
        if(GraphVectors.ContainsKey(Source) && GraphVectors.ContainsKey(Destintion))
        {
            int sourceIndex= GraphVectors[Source];
            int destinationIndex = GraphVectors[Destintion];

            adjancecyMatrix[sourceIndex, destinationIndex] = Wight;
            if(enGraphType1 == enGraphType.Undirected)
            {
                adjancecyMatrix[destinationIndex, sourceIndex] = Wight;
            }
        }else
        {
            Console.WriteLine("The vectors is " + Source + "------>" + Destintion);
        }
    }

    public void RemoveEdge(string source, string destination)
    {
        if(GraphVectors.ContainsKey(source) && GraphVectors.ContainsKey(destination))
        {
            int sourceIndex = GraphVectors[source];
            int destinationIndex = GraphVectors[destination];
            if(enGraphType1 == enGraphType.Undirected)
            {
                adjancecyMatrix[sourceIndex, destinationIndex] = 0;
                adjancecyMatrix[destinationIndex, sourceIndex] = 0;
            }else
            {
                adjancecyMatrix[sourceIndex, destinationIndex] = 0;
            }

        }
        else
        {
            Console.WriteLine("The vectors is " + source + "------>" + destination);

        }
    }
    public bool IsEdge(string source, string destination)
    {
        if (GraphVectors.ContainsKey(source) && GraphVectors.ContainsKey(destination))
        {
            int sourceIndex = GraphVectors[source];
            int destinationIndex = GraphVectors[destination];

            return adjancecyMatrix[sourceIndex, destinationIndex] > 0;
        }
        return false;
    }

    public int GetInVertices(string source)
    {
        int degree = 0;
        if(GraphVectors.ContainsKey(source))
        {
            int sourceIndex = GraphVectors[source];

            for(int i = 0; i< NumberOfVectors; i++)
            {
                if (adjancecyMatrix[i, sourceIndex] > 0)
                {
                    degree++;
                }
            }
        }
        return degree;
    }

    public int GetOutVertices(string source)
    {
        int degree = 0;
        if (GraphVectors.ContainsKey(source))
        {
            int sourceIndex = GraphVectors[source];

            for (int i = 0; i < NumberOfVectors; i++)
            {
                if (adjancecyMatrix[sourceIndex, i] > 0)
                {
                    degree++;
                }
            }
        }
        return degree;
    }
    public void DisplayGraph()
    {
        Console.Write("  ");
        foreach(string source in GraphVectors.Keys)
        {
            Console.Write(" " + source);
        }
        
        Console.WriteLine();

        foreach (var source in GraphVectors)
        {
            Console.Write(" " + source.Key);

            for(int i = 0; i< NumberOfVectors; i++)
            {
                Console.Write(" "+adjancecyMatrix[source.Value, i]);
            }
            Console.WriteLine();
        }

    }

    public static void Main(string[] args)
    {
        // Create a list of vertices with string labels
        List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };


        //Example 1 in Slides: Undirected Graph
        // Create a new graph object with the specified vertices
        Graph graph1 = new Graph(vertices, enGraphType.Undirected);

        // Add some edges with default weights=1 between vertices
        graph1.AddEdge("A", "B", 1);
        graph1.AddEdge("A", "C", 1);
        graph1.AddEdge("B", "D", 1);
        graph1.AddEdge("C", "D", 1);
        graph1.AddEdge("B", "E", 1);
        graph1.AddEdge("D", "E", 1);



        // Display the adjacency matrix with weights to visualize the graph
        graph1.DisplayGraph();

        Console.WriteLine("\n------------------------------\n");

        //Example 2 in Slides: Directed Graph
        // Create a new graph object with the specified vertices
        Graph graph2 = new Graph(vertices, enGraphType.Directed);

        // Add some edges with weights between vertices
        graph2.AddEdge("A", "A", 1);
        graph2.AddEdge("A", "B", 1);
        graph2.AddEdge("A", "C", 1);
        graph2.AddEdge("B", "E", 1);
        graph2.AddEdge("D", "B", 1);
        graph2.AddEdge("D", "C", 1);
        graph2.AddEdge("D", "E", 1);

        // Display the adjacency matrix with weights to visualize the graph
        graph2.DisplayGraph();


        // Get and display the Indegree (number of edges) of vertex 'D'
        Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInVertices("D"));

        // Get and display the Outdegree (number of edges) of vertex 'D'
        Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutVertices("D"));

        Console.WriteLine("\n------------------------------\n");

        //Example 3 in Slides: Weighted Graph
        // Create a new graph object with the specified vertices
        Graph graph3 = new Graph(vertices, enGraphType.Undirected);

        // Add some edges with weights between vertices
        graph3.AddEdge("A", "B", 5);
        graph3.AddEdge("A", "C", 3);
        graph3.AddEdge("B", "D", 12);
        graph3.AddEdge("C", "D", 10);
        graph3.AddEdge("B", "E", 2);
        graph3.AddEdge("D", "E", 7);

        // Display the adjacency matrix with weights to visualize the graph
        graph3.DisplayGraph();


        // Check if there is an edge between 'A' and 'B' and display the result
        Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));


        // Check if there is an edge between 'A' and 'B' and display the result
        Console.WriteLine("\nIs there an edge between B and C in Graph3? " + graph3.IsEdge("B", "C"));


        // Check if there is an edge between 'A' and 'A' and display the result
        Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

        // Check if there is an edge between 'A' and 'A' and display the result
        Console.WriteLine("\nIs there an edge between A and A in Graph3? " + graph3.IsEdge("A", "A"));


        // Get and display the Indegree (number of edges) of vertex 'A'
        Console.WriteLine("\nInDegree of vertex A: " + graph3.GetInVertices("A"));

        // Get and display the Indegree (number of edges) of vertex 'A'
        Console.WriteLine("\nOutDegree of vertex A: " + graph3.GetOutVertices("A"));

        Console.WriteLine("\n------------------------------\n");


        Console.WriteLine("\nRemoveing Edge between E and D:");
        // Remove the edge between 'E' and 'D'
        graph3.RemoveEdge("E", "D");

        // Display the updated adjacency matrix after removing the edge
        graph3.DisplayGraph();


        // Check if there is an edge between 'A' and 'A' and display the result
        Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));


        Console.ReadKey();

    }

}