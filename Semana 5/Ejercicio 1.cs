//Escribir un programa que almacene las asignaturas de un curso en una lista y la muestre por pantalla 
//el mensaje Yo estudio <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.

using System;
using System.Collections.Generic;

namespace MisEjercicios

{
    public static class Ejercicio1
    {
        public static void Ejecutar()
        {
            //Lista de asignaturas
            var asignaturas = new List<string>
            {
                "Administracion de SO",
            "Ingles",
            "Estructura de datos",
            "Sistemas digitales",
            "Instalaciones electricas"
            };
            
            ////Mostrar mensaje para cada asignatura
            foreach (var a in asignaturas)
        Console.WriteLine($"Yo estudio {a}");           
        }
    }           
}