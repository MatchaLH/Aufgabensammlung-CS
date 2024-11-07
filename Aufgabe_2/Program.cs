using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von Sekunden eines Monat in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");

            int Tage = Convert.ToInt32(Console.ReadLine());
            int erg = 86400 * Tage;

            if (Tage <= 31 && Tage >27)
            {
                Console.WriteLine("Ein Monat mit " + Tage + " Tagen hat " + erg + " Sekunden");
            }
            else 
            { 
                Console.WriteLine("Ungültige Eingabe");
            }

                Console.ReadKey();
        }
    }
}
