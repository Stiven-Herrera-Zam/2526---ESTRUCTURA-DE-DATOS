using System;
using System.Collections.Generic;

class Deportista
{
    public string Nombre;
    public string Disciplina;
    public HashSet<string> Premios = new HashSet<string>();
}

class Program
{
    // Mapa donde la clave es el nombre del deportista
    static Dictionary<string, Deportista> deportistas = new Dictionary<string, Deportista>();

    static void Main()
    {
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("=== Premiación de Deportistas ===");
            Console.WriteLine("1. Registrar deportista");
            Console.WriteLine("2. Agregar premio");
            Console.WriteLine("3. Ver deportistas");
            Console.WriteLine("4. Ver premios por deportista");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            if (opcion == 1)
            {
                RegistrarDeportista();
            }
            else if (opcion == 2)
            {
                AgregarPremio();
            }
            else if (opcion == 3)
            {
                VerDeportistas();
            }
            else if (opcion == 4)
            {
                VerPremios();
            }
        }
    }

    static void RegistrarDeportista()
    {
        Console.Write("Nombre del deportista: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre)) { Console.WriteLine("Nombre inválido.\n"); return; }

        Console.Write("Disciplina: ");
        string? disciplina = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(disciplina)) { Console.WriteLine("Disciplina inválida.\n"); return; }

        if (!deportistas.ContainsKey(nombre))
        {
            Deportista dep = new Deportista();
            dep.Nombre = nombre;
            dep.Disciplina = disciplina;

            deportistas.Add(nombre, dep);

            Console.WriteLine("Deportista registrado.\n");
        }
        else
        {
            Console.WriteLine("Ese deportista ya existe.\n");
        }
    }

    static void AgregarPremio()
    {
        Console.Write("Nombre del deportista: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre)) { Console.WriteLine("Nombre inválido.\n"); return; }

        if (deportistas.ContainsKey(nombre))
        {
            Console.Write("Premio obtenido: ");
            string? premio = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(premio)) { Console.WriteLine("Premio inválido.\n"); return; }

            deportistas[nombre].Premios.Add(premio);

            Console.WriteLine("Premio agregado.\n");
        }
        else
        {
            Console.WriteLine("El deportista no está registrado.\n");
        }
    }

    static void VerDeportistas()
    {
        Console.WriteLine("\n--- Lista de Deportistas ---");

        foreach (var d in deportistas.Values)
        {
            Console.WriteLine("Nombre: " + d.Nombre + " | Disciplina: " + d.Disciplina);
        }

        Console.WriteLine();
    }

    static void VerPremios()
    {
        Console.Write("Nombre del deportista: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre)) { Console.WriteLine("Nombre inválido.\n"); return; }

        if (deportistas.ContainsKey(nombre))
        {
            Console.WriteLine("\nPremios de " + nombre + ":");

            foreach (var p in deportistas[nombre].Premios)
            {
                Console.WriteLine("- " + p);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Ese deportista no existe.\n");
        }
    }
}