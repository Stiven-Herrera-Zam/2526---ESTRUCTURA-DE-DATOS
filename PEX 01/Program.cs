using System;
namespace AgendaTelefonica
{
    class Program    // Clase principal del programa
    {
        static void Main(string[]args)    // Método Main: punto de entrada de la aplicación
        {
            Agenda agenda = new Agenda();   // Crea una instancia de la clase Agenda
            agenda.Menu();                // Llama al método Menu() para iniciar la interacción con el usuario
        }

    }
}
