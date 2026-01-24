

using System;
using System.Collections.Generic;

class ParentesisBalanceados
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== VERIFICADOR DE PARÉNTESIS, LLAVES Y CORCHETES ===");
        Console.WriteLine("Ejemplo: {7 + (8 * 5) - [(9 - 7) + (4 + 1)]}");
        Console.Write("\nIngresa la expresión: ");

        string expresion = Console.ReadLine() ?? string.Empty;

        if (EstaBalanceada(expresion))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFórmula balanceada.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nFórmula NO balanceada.");
        }

        Console.ResetColor();
        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }

    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Aperturas
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Cierres
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();
                if (!EsParCorrecto(tope, c))
                    return false;
            }
        }

        // Si no quedó nada sin cerrar, está balanceada
        return pila.Count == 0;
    }

    static bool EsParCorrecto(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}
