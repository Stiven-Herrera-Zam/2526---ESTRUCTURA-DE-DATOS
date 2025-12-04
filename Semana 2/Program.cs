
// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ESTRUCTURA DE DATOS - UEA");
        Console.WriteLine();
        // Ejemplo con Cuadrado
        Cuadrado cuadrado = new Cuadrado(5);
        Console.WriteLine("Figura          | Valor");
        Console.WriteLine("----------------|----------------");
        Console.WriteLine("Cuadrado - Lado | " + cuadrado.Lado);
        Console.WriteLine("Área            | " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro       | " + cuadrado.CalcularPerimetro());
        Console.WriteLine();

        // Ejemplo con Círculo
        Circulo circulo = new Circulo(10.5);
        Console.WriteLine("Círculo - Radio | " + circulo.Radio);
        Console.WriteLine("Área            | " + circulo.CalcularArea());
        Console.WriteLine("Perímetro       | " + circulo.CalcularPerimetro());

        Console.WriteLine();
    }
}