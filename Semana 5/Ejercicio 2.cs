//Escribir un programa que pregunte al usuario los números ganadores de la lotería primitiva,
 //los almacene en una lista y los muestre por pantalla ordenados de menor a mayor.

using System;
using System.Collections.Generic;

namespace MisEjercicios
{
    public static class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingresa números separados por espacios o comas:");
            string entrada = Console.ReadLine() ?? "";

            var tokens = entrada.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var numeros = new List<int>();

            foreach (var t in tokens)
            {
                if (int.TryParse(t, out int n))
                    numeros.Add(n);
                else
                    Console.WriteLine($"⚠️ '{t}' no es válido y se ignora.");
            }

            numeros.Sort();
            Console.WriteLine("Ordenados: " + string.Join(", ", numeros));
        }
    }
}
