﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ganzzahlig Dezimalzahl");
            int zahl = Convert.ToInt32(Console.ReadLine());
            string bin = Convert.ToString(zahl, 2);
            Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);

            Console.ReadKey();
        }
    }
}