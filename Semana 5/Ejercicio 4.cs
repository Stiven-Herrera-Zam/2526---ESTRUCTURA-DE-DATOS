//Escribir un programa que pregunte por una muestra de números, separados por comas,
//los guarde en una lista y muestre por pantalla su media y desviación típica.


using System;
using System.Collections.Generic;
using System.Linq;

namespace MisEjercicios
{
    public static class Ejercicio4
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingresa números separados por comas:");
            string entrada = Console.ReadLine() ?? "";

            var nums = entrada
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => double.Parse(s.Trim()))
                .ToList();

            if (nums.Count == 0)
            {
                Console.WriteLine("No se ingresaron números.");
                return;
            }

            double media = nums.Average();
            double sumaCuadrados = nums.Sum(x => Math.Pow(x - media, 2));
            double desviacionTipica = Math.Sqrt(sumaCuadrados / nums.Count);

            Console.WriteLine($"Media: {media:F2}");
            Console.WriteLine($"Desviación típica: {desviacionTipica:F2}");
        }
    }
}
