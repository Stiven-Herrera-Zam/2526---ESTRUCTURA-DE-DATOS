using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Insertar elementos
            lista.InsertarFinal(5);
            lista.InsertarFinal(10);
            lista.InsertarFinal(15);

            Console.WriteLine("Lista enlazada:");
            lista.Mostrar();

            Console.WriteLine("Número de elementos: " + lista.Longitud());

            // Lista vacía
            ListaEnlazada listaVacia = new ListaEnlazada();
            Console.WriteLine("\nLista vacía:");
            listaVacia.Mostrar();
            Console.WriteLine("Número de elementos: " + listaVacia.Longitud());
        }
    }
}
