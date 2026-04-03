using System;
using System.Collections.Generic;

class Grafo
{
    // Diccionario para guardar el grafo
    Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();

    // Agregar conexión entre dos nodos
    public void AgregarConexion(string nodo1, string nodo2)
    {
        if (!grafo.ContainsKey(nodo1))
        {
            grafo[nodo1] = new List<string>();
        }

        if (!grafo.ContainsKey(nodo2))
        {
            grafo[nodo2] = new List<string>();
        }

        grafo[nodo1].Add(nodo2);
        grafo[nodo2].Add(nodo1);
    }

    // Mostrar el grafo
    public void MostrarGrafo()
    {
        foreach (var nodo in grafo)
        {
            Console.Write(nodo.Key + " -> ");
            foreach (var conexion in nodo.Value)
            {
                Console.Write(conexion + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // -------------------------
        // EJEMPLO 1: CIUDADES
        // -------------------------
        Grafo grafoCiudades = new Grafo();

        grafoCiudades.AgregarConexion("Quito", "Guayaquil");
        grafoCiudades.AgregarConexion("Quito", "Cuenca");
        grafoCiudades.AgregarConexion("Guayaquil", "Manta");
        grafoCiudades.AgregarConexion("Cuenca", "Loja");

        Console.WriteLine("EJEMPLO 1: GRAFO DE CIUDADES");
        grafoCiudades.MostrarGrafo();

        Console.WriteLine();

        // -------------------------
        // EJEMPLO 2: AMIGOS
        // -------------------------
        Grafo grafoAmigos = new Grafo();

        grafoAmigos.AgregarConexion("Ana", "Luis");
        grafoAmigos.AgregarConexion("Ana", "Pedro");
        grafoAmigos.AgregarConexion("Luis", "Maria");
        grafoAmigos.AgregarConexion("Pedro", "Maria");

        Console.WriteLine("EJEMPLO 2: GRAFO DE AMIGOS");
        grafoAmigos.MostrarGrafo();

        Console.ReadLine(); // Para que no se cierre la consola
    }
}
