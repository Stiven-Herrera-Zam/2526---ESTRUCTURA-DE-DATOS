using System;
using System.Collections.Generic;

class Ciudadano
{
    public int Id;
    public string Nombre;

    public Ciudadano(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public override string ToString()
    {
        return Id + " - " + Nombre;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1) Crear 500 ciudadanos ficticios
        List<Ciudadano> todosLista = new List<Ciudadano>();
        for (int i = 1; i <= 500; i++)
        {
            todosLista.Add(new Ciudadano(i, "Ciudadano " + i));
        }

        // Conjunto con los IDs de todos
        HashSet<int> todos = new HashSet<int>();
        foreach (var c in todosLista)
            todos.Add(c.Id);

        // 2) Crear conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        HashSet<int> pfizer = GenerarVacunadosAleatorios(todosLista, 75);

        // 3) Crear conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        HashSet<int> astra = GenerarVacunadosAleatorios(todosLista, 75);

        // --------------------------
        // Operaciones de conjuntos
        // --------------------------

        // Unión: vacunados (Pfizer U Astra)
        HashSet<int> vacunados = new HashSet<int>(pfizer);
        vacunados.UnionWith(astra);

        // Intersección: ambas dosis (Pfizer ∩ Astra)
        HashSet<int> ambasDosis = new HashSet<int>(pfizer);
        ambasDosis.IntersectWith(astra);

        // Solo Pfizer: Pfizer \ Astra
        HashSet<int> soloPfizer = new HashSet<int>(pfizer);
        soloPfizer.ExceptWith(astra);

        // Solo Astra: Astra \ Pfizer
        HashSet<int> soloAstra = new HashSet<int>(astra);
        soloAstra.ExceptWith(pfizer);

        // No vacunados: Todos \ (Pfizer U Astra)
        HashSet<int> noVacunados = new HashSet<int>(todos);
        noVacunados.ExceptWith(vacunados);

        // --------------------------
        // Mostrar resultados
        // --------------------------

        Console.WriteLine("==== RESULTADOS ====");
        Console.WriteLine("Total ciudadanos: " + todos.Count);
        Console.WriteLine("Vacunados Pfizer: " + pfizer.Count);
        Console.WriteLine("Vacunados AstraZeneca: " + astra.Count);
        Console.WriteLine();

        Console.WriteLine("1) No vacunados: " + noVacunados.Count);
        MostrarAlgunos(noVacunados, todosLista);

        Console.WriteLine("\n2) Ambas dosis (Pfizer y AstraZeneca): " + ambasDosis.Count);
        MostrarAlgunos(ambasDosis, todosLista);

        Console.WriteLine("\n3) Solo Pfizer: " + soloPfizer.Count);
        MostrarAlgunos(soloPfizer, todosLista);

        Console.WriteLine("\n4) Solo AstraZeneca: " + soloAstra.Count);
        MostrarAlgunos(soloAstra, todosLista);

        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }

    static HashSet<int> GenerarVacunadosAleatorios(List<Ciudadano> lista, int cantidad)
    {
        Random r = new Random();
        HashSet<int> resultado = new HashSet<int>();

        while (resultado.Count < cantidad)
        {
            int pos = r.Next(0, lista.Count); // posición aleatoria
            resultado.Add(lista[pos].Id);     // agrega el ID
        }

        return resultado;
    }

    static void MostrarAlgunos(HashSet<int> conjunto, List<Ciudadano> lista)
    {
        // Muestra solo algunos para no imprimir 500 líneas
        int mostrados = 0;
        foreach (int id in conjunto)
        {
            // Buscar el ciudadano por id de forma simple
            Ciudadano c = lista[id - 1]; // porque los IDs van 1..500
            Console.WriteLine("   " + c);

            mostrados++;
            if (mostrados == 10) break;
        }

        if (conjunto.Count > 10)
            Console.WriteLine("   ... (mostrando 10 de " + conjunto.Count + ")");
    }
}
