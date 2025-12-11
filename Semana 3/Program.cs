using System;     //Importa la libreria system que permite usar consola

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();  //Se crea un objeto de tipo estudiante, esto permite guardar ID, Nombres, Apellidos....

        Console.Write("Ingrese el ID del estudiante: ");  //Solicita al usuario el ID del estudiante
        estudiante.ID = int.Parse(Console.ReadLine());  //Lee lo que escriba el usuario y lo convierte a entero

        Console.Write("Ingrese los nombres: "); //Solicita los nombres de los estudiantes
        estudiante.Nombres = Console.ReadLine();  //Guarda lo ingresado

        Console.Write("Ingrese los apellidos: ");  //Solicita los apellidos
        estudiante.Apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección: ");  //Solicita la dirección
        estudiante.Direccion = Console.ReadLine();

        Console.WriteLine("\nIngrese los 3 números de teléfono:");  //Mensaje previo para ingresar los teléfonos
        for (int i = 0; i < estudiante.Telefonos.Length; i++)  //Bucle for que se repite 3 veces 
        {
            Console.Write($"Teléfono {i + 1}: ");  //Pide el telefono número (i+1)
            estudiante.Telefonos[i] = Console.ReadLine();  //Guarda el telefono ingresado dentro del array
        }

        estudiante.MostrarDatos();  //Llama al método MostrarDatos(), imprime todos los datos del estudiante

        Console.WriteLine("\nPresione cualquier tecla para salir...");  //Mesaje final
        Console.ReadKey();  //Espera a que el usuario presione una tecla antes de salir
    }
}
