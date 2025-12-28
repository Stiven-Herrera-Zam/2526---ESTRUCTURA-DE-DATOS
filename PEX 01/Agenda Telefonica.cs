using System;

namespace AgendaTelefonica
{
    class Agenda          // Clase principal que gestiona la agenda
    {
        Contacto[] contactos = new Contacto[50];    // Arreglo fijo de 50 contactos
        int contador = 0;                  // Lleva la cuenta de cuántos contactos se han registrado

        public void Menu()           // Método que muestra el menú principal y controla el flujo de la aplicación
        {
            int opcion;
            do
            {
                Console.Clear();              // Limpia la pantalla antes de mostrar el menú

                Console.WriteLine("=== AGENDA TELEFÓNICA ===");   // Opciones del menú
                Console.WriteLine("1. Registrar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());  // Convierte la entrada del usuario a entero. 

                switch (opcion)        // Selecciona la acción según la opción elegida
                {
                    case 1:
                        // Llama al registro de un nuevo contacto
                        RegistrarContacto();
                        break;
                    case 2:
                        // Muestra la lista de contactos registrados
                        MostrarContactos();
                        break;
                    case 3:
                        // Permite buscar un contacto por nombre
                        BuscarContacto();
                        break;
                    case 4:
                        // Finaliza el bucle y sale del programa
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        // Opción no válida
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                
                // Pausa para que el usuario vea el resultado antes de continuar
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 4);        // Repite el menú hasta que el usuario elija salir
        }

        void RegistrarContacto()        // Registra un nuevo contacto si hay espacio en el arreglo
        {
            // Verifica que aún haya espacio en la agenda
            if (contador < contactos.Length)
            {
                contactos[contador] = new Contacto();  // Crea un nuevo objeto Contacto en la posición actual

                Console.Write("Nombre: ");      // Solicita y guarda el nombre del contacto
                contactos[contador].Nombre = Console.ReadLine();

                Console.Write("Teléfono: ");    // Solicita y guarda el teléfono del contacto
                contactos[contador].Telefono = Console.ReadLine();

                Console.Write("Correo: ");    // Solicita y guarda el correo del contacto
                contactos[contador].Correo = Console.ReadLine();

                contador++;             // Aumenta el contador tras registrar el contacto
                Console.WriteLine("Contacto registrado correctamente.");
            }
            else
            {
                         // Mensaje si el arreglo de contactos está llena
                Console.WriteLine("Agenda llena.");
            }
        }

        void MostrarContactos()   // Muestra todos los contactos registrados hasta el momento
        {
            Console.WriteLine("\n--- LISTA DE CONTACTOS ---");

            for (int i = 0; i < contador; i++)   // Recorre los contactos desde 0 hasta contador - 1
            {
                Console.WriteLine($"Contacto #{i + 1}");
                Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                Console.WriteLine($"Correo: {contactos[i].Correo}");
                Console.WriteLine("-------------------------");
            }
        }

        void BuscarContacto()  // Busca un contacto por nombre (comparación sin distinguir mayúsculas/minúsculas)
        {
            // Pide el nombre a buscar
            Console.Write("Ingrese el nombre a buscar: ");
            string nombre = Console.ReadLine();

            // Bandera para saber si se encontró el contacto
            bool encontrado = false;

            // Recorre los contactos registrados
            for (int i = 0; i < contador; i++)
            {
                // Compara el nombre ingresado con el nombre del contacto, ignorando mayúsculas/minúsculas
                if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                { 
                    // Muestra los datos del contacto encontrado
                    Console.WriteLine("\nContacto encontrado:");
                    Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                    Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                    Console.WriteLine($"Correo: {contactos[i].Correo}");

                    // Marca como encontrado y termina la búsqueda
                    encontrado = true;
                    break;
                }
            }

            // Si no se encontró ningún contacto con ese nombre
            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    }
}
