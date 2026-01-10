//Escribir un programa que almacene en una lista los siguientes precios, 50, 75, 46, 22, 80, 65, 8,
// muestre por pantalla el menor y el mayor de los precios.


using System;
using System.Collections.Generic;
using System.Linq;

namespace MisEjercicios
{
    public static class Ejercicio5
    {
        public static void Ejecutar()
        {
            var precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
            Console.WriteLine($"Menor precio: {precios.Min()}");
            Console.WriteLine($"Mayor precio: {precios.Max()}");
        }
    }
}
