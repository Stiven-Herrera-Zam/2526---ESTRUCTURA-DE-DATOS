using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Crear lista con 50 números aleatorios
            lista.LlenarAleatorio(50);

            Console.WriteLine("Lista original (50 números aleatorios):");
            lista.Mostrar();
            Console.WriteLine("Cantidad de elementos: " + lista.Longitud());

            // Leer rango
            Console.Write("\nIngrese el límite inferior: ");
            int min = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el límite superior: ");
            int max = int.Parse(Console.ReadLine()!);

            // Eliminar fuera del rango
            lista.EliminarFueraDeRango(min, max);

            Console.WriteLine("\nLista después de eliminar valores fuera del rango:");
            lista.Mostrar();
            Console.WriteLine("Cantidad de elementos final: " + lista.Longitud());
        }
    }
}

