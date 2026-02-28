using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario simple: español -> inglés
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("hola", "hello");
        dic.Add("mundo", "world");
        dic.Add("gato", "cat");
        dic.Add("perro", "dog");
        dic.Add("casa", "house");
        dic.Add("carro", "car");
        dic.Add("agua", "water");
        dic.Add("comida", "food");
        dic.Add("sol", "sun");
        dic.Add("luna", "moon");

        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Ingresa un número válido.");
                opcion = -1;
                continue;
            }

            if (opcion == 1)
            {
                // Traducir frase ES -> EN
                Console.Write("Escribe una frase en español: ");
                string frase = (Console.ReadLine() ?? "").ToLower();  // Guarda la frase en minusculas

                // Dividir por espacios y evitar vacíos
                string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("Traducción:");
                foreach (string p in palabras)
                {
                    if (dic.ContainsKey(p))
                        Console.Write(dic[p] + " ");
                    else
                        Console.Write("[" + p + "] "); // no encontrada
                }
                Console.WriteLine();
            }
            else if (opcion == 2)
            {
                // Agregar par (ES -> EN)
                Console.Write("Palabra en español: ");
                string esp = (Console.ReadLine() ?? "").ToLower();

                if (esp == "")
                {
                    Console.WriteLine("No escribiste nada.");
                    continue;
                }

                if (dic.ContainsKey(esp))
                {
                    Console.WriteLine("Esa palabra ya existe en el diccionario.");
                }
                else
                {
                    Console.Write("Traducción al inglés: ");
                    string ing = (Console.ReadLine() ?? "").ToLower();

                    if (ing == "")
                    {
                        Console.WriteLine("No escribiste la traducción.");
                        continue;
                    }

                    dic.Add(esp, ing);
                    Console.WriteLine("Palabra agregada correctamente.");
                }
            }
            else if (opcion == 0)
            {
                Console.WriteLine("Adiós :)");
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }
}