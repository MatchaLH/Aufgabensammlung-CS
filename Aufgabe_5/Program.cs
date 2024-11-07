using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen? ");
            Console.Write("Anzahl km: ");
            int km = Convert.ToInt32(Console.ReadLine());
            if (km > 42)
            {
                Console.WriteLine("Das Schaffst du nicht!");
                Environment.Exit(0);
            }
            int runden = ((km * 1000) / 400);
            Console.WriteLine("Das sind " + runden + " runden. Bereit für den Lauf?");
            Console.WriteLine("Schreibe Ja wenn du bereit bist");
            if (Console.ReadLine().ToLower() != "ja")
            {
                Environment.Exit(0);
            }
            int i = 1;
            while (i <= runden)
            {
                Console.WriteLine("Du läufst Runde " + i);
                i++;
            }
                Console.WriteLine("\nDu hast es geschaft");

            Console.ReadKey();

        }
    }
}
