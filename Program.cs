﻿using System;
using LocationVoiture;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture(1, "Peugeot", "208", 2019, "Disponible");
            Voiture v2 = new Voiture(2, "Renault", "Clio", 2018, "Indisponible");

            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}