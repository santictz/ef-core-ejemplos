﻿using System;

namespace EFCoreEjemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    //Crear Modelo
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}
