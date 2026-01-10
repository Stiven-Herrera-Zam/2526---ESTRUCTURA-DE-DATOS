// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace MisEjercicios
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Menú de ejercicios ===");
                Console.WriteLine("1) Asignaturas");
                Console.WriteLine("2) Lotería");
                Console.WriteLine("3) 1 al 10 inverso");
                Console.WriteLine("4) Media y desviación");
                Console.WriteLine("5) Precios: min y max");
                Console.WriteLine("0) Salir");
                Console.Write("Opción: ");
                var op = Console.ReadLine();

                Console.WriteLine();

                switch (op)
                {
                    case "1": Ejercicio1.Ejecutar(); break;
                    case "2": Ejercicio2.Ejecutar(); break;
                    case "3": Ejercicio3.Ejecutar(); break;
                    case "4": Ejercicio4.Ejecutar(); break;
                    case "5": Ejercicio5.Ejecutar(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresiona una tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }
}
