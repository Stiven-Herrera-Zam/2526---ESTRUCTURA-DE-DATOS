using System;  //Importa funcionalidades básicas del sistema 

class Estudiante  //Definimos la clase estudiante
{
    public int ID { get; set; }  //Propiedad para almacemar el ID
    public string Nombres { get; set; }  //Propiedad para los nombres, se usa string para evitar advertencias
    public string Apellidos { get; set; }  //Propiedad para los apellidos
    public string Direccion { get; set; }  //Propiedad para la dirección
    public string[] Telefonos { get; set; } = new string[3];  //Array de 3 posiciones para almacenar los teléfonos

    public void MostrarDatos()  //Método para mostrar todos los datos del estudiante en consola
    {
        Console.WriteLine("\n===== DATOS DEL ESTUDIANTE =====");
        Console.WriteLine($"ID: {ID}");                     //Muestra el Id
        Console.WriteLine($"Nombres: {Nombres}");           //Muestra los nombres
        Console.WriteLine($"Apellidos: {Apellidos}");       //Muestra los apellidos
        Console.WriteLine($"Dirección: {Direccion}");       //Muestra la dirección
        Console.WriteLine("Teléfonos:");                    //Imprime los teléfonos
        for (int i = 0; i < Telefonos.Length; i++)     //Recorre el array telefonos usando un bucle for
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}
