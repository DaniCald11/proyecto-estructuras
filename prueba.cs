// See https://aka.ms/new-console-template for more information

using System;

class Grafo
{
    private int[,] matrizAdyacencia;
    private int numVertices;

    public Grafo(int numVertices)
    {
        this.numVertices = numVertices;
        matrizAdyacencia = new int[numVertices, numVertices];
    }

    public void AgregarArista(int origen, int destino, int peso)
    {
        matrizAdyacencia[origen, destino] = peso;
        // Si el grafo es no dirigido, descomenta la línea siguiente
        // matrizAdyacencia[destino, origen] = peso;
    }

    public void ImprimirMatrizAdyacencia()
    {
        Console.WriteLine("Matriz de Adyacencia:");
        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                Console.Write(matrizAdyacencia[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numVertices = 5;  // Cambia el número de vértices según tu grafo
        Grafo grafo = new Grafo(numVertices);

        // Agrega las aristas con sus respectivos pesos
        grafo.AgregarArista(0, 1, 2);
        grafo.AgregarArista(0, 2, 1);
        grafo.AgregarArista(1, 3, 4);
        grafo.AgregarArista(2, 4, 3);
        grafo.AgregarArista(3, 4, 5);

        // Imprime la matriz de adyacencia
        grafo.ImprimirMatrizAdyacencia();
    }
}
