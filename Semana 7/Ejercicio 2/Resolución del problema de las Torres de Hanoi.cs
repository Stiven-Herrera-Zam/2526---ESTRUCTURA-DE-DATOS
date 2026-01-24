
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== TORRES DE HANOI (usando pilas) ===");
        int n = LeerEnteroPositivo("Número de discos (recomendado 3–8): ");

        // Declarar las tres torres como pilas
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Cargar la torre origen con n..1 (1 es el más pequeño)
        for (int disco = n; disco >= 1; disco--)
            origen.Push(disco);

        Console.WriteLine($"\nEstado inicial con {n} discos:");
        ImprimirEstado(origen, auxiliar, destino);

        long totalMovs = 0;

        ResolverHanoi(
            n,
            origen, destino, auxiliar,
            "Origen", "Destino", "Auxiliar",
            onMove: (disco, desde, hacia) =>
            {
                totalMovs++;
                Console.WriteLine($"Mover disco {disco} de {desde} a {hacia}");
                ImprimirEstado(origen, auxiliar, destino);
            });

        Console.WriteLine($"¡Listo! Total de movimientos: {totalMovs} (esperado: {((1L << n) - 1)})");
        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }

    /// <summary>
    /// Solución recursiva clásica que mueve n discos entre pilas,
    /// notificando cada movimiento vía el callback onMove.
    /// </summary>
    static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar,
        string nombreOrigen,
        string nombreDestino,
        string nombreAuxiliar,
        Action<int, string, string> onMove)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino, onMove);
            return;
        }

        // 1) Mueve n-1 desde origen -> auxiliar
        ResolverHanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino, onMove);

        // 2) Mueve disco n desde origen -> destino
        MoverDisco(origen, destino, nombreOrigen, nombreDestino, onMove);

        // 3) Mueve n-1 desde auxiliar -> destino
        ResolverHanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen, onMove);
    }

    /// <summary>
    /// Saca un disco de 'desde' y lo coloca en 'hacia', validando la regla:
    /// no colocar un disco grande sobre uno más pequeño.
    /// </summary>
    static void MoverDisco(
        Stack<int> desde,
        Stack<int> hacia,
        string nombreDesde,
        string nombreHacia,
        Action<int, string, string> onMove)
    {
        if (desde.Count == 0)
            throw new InvalidOperationException($"No hay discos en {nombreDesde} para mover.");

        int disco = desde.Pop();

        if (hacia.Count > 0 && disco > hacia.Peek())
            throw new InvalidOperationException(
                $"Movimiento inválido: no puedes poner {disco} sobre {hacia.Peek()} en {nombreHacia}.");

        hacia.Push(disco);
        onMove(disco, nombreDesde, nombreHacia);
    }

    /// <summary>
    /// Imprime el contenido de cada torre. Muestra del tope al fondo.
    /// </summary>
    static void ImprimirEstado(Stack<int> origen, Stack<int> auxiliar, Stack<int> destino)
    {
        Console.WriteLine($"Origen : [{string.Join(", ", origen.ToArray())}]");
        Console.WriteLine($"Auxiliar: [{string.Join(", ", auxiliar.ToArray())}]");
        Console.WriteLine($"Destino: [{string.Join(", ", destino.ToArray())}]");
        Console.WriteLine();
    }

    static int LeerEnteroPositivo(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string? s = Console.ReadLine();
            if (int.TryParse(s, out int n) && n > 0)
                return n;

            Console.WriteLine("Valor inválido. Intenta otra vez (entero > 0).");
        }
    }
}
