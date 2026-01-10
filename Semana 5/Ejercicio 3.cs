//Escribir un programa que almacene en una lista los números del 1 al 10
// y los muestre por pantalla en orden inverso separados por comas.

using System;
using System.Linq;

namespace MisEjercicios
{
    public static class Ejercicio3
    {
        public static void Ejecutar()
        {
            var numeros = Enumerable.Range(1, 10).ToList();
            numeros.Reverse();
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}
