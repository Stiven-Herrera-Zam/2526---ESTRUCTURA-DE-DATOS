using System;

namespace Ejercicio_1
{
    // Nodo de lista enlazada simple
    public class Nodo
    {
        public int Valor;
        public Nodo? Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    // Lista enlazada simple
    public class ListaEnlazada
    {
        private Nodo? cabeza;

        // Insertar al final
        public void InsertarFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (cabeza == null)
            {
                cabeza = nuevo;
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevo;
        }

        // FUNCIÓN PEDIDA: calcular número de elementos
        public int Longitud()
        {
            int contador = 0;
            Nodo? actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }

        // Mostrar lista
        public void Mostrar()
        {
            Nodo? actual = cabeza;

            if (actual == null)
            {
                Console.WriteLine("Lista vacía");
                return;
            }

            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }

            Console.WriteLine("null");
        }
    }
}
