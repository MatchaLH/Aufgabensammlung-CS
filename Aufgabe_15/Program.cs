using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int breite = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe des Stammes? ");
            int höhe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int krone = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            ZeichneKrone(krone);
            ZeichneStamm(breite, höhe, krone);
        }

        static void ZeichneStamm(int breiteStamm, int höheStamm, int höheKrone)
        {

            for (int i = 0; i < höheStamm; i++)
            {
                ZeichneZeile(((((höheKrone * 2) - 1) - breiteStamm) / 2), breiteStamm);
            }
        }

        static void ZeichneKrone(int hoeheKrone)
        {
            for (int i = 0; i < hoeheKrone; i++)
            {
                ZeichneZeile((hoeheKrone - i - 1), (i * 2) + 1);
            }
        }

        static void ZeichneZeile(int anzahlLeer, int anzahlSterne)
        {
            for (int i = 0; i < anzahlLeer; i++)
            {
                Console.Write(" ");
            }
            for
                (int i = 0; i < anzahlSterne; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
