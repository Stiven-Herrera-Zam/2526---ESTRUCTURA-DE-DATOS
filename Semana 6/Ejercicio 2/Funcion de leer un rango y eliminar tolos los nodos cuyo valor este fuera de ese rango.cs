using System;

namespace Ejercicio_2
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

        // Crear lista con números aleatorios
        public void LlenarAleatorio(int cantidad)
        {
            Random rnd = new Random();

            for (int i = 0; i < cantidad; i++)
            {
                InsertarFinal(rnd.Next(1, 1000)); // 1 a 999
            }
        }

        // Eliminar nodos fuera del rango [min, max]
        public void EliminarFueraDeRango(int min, int max)
        {
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            // Ajustar cabeza
            while (cabeza != null && (cabeza.Valor < min || cabeza.Valor > max))
            {
                cabeza = cabeza.Siguiente;
            }

            if (cabeza == null) return;

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Valor < min || actual.Siguiente.Valor > max)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                }
                else
                {
                    actual = actual.Siguiente;
                }
            }
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

        // Contar elementos
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
    }
}
