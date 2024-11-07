using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************");
            Console.Write("Eingabe Jahr :");
            int jahr = Convert.ToInt32(Console.ReadLine());
            bool schalt = (jahr % 4 == 0 && (jahr % 100 != 0 || jahr % 400 == 0));

            if (schalt)
            {
                Console.WriteLine($"{jahr} ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine($"{jahr} ist kein Schaltjahr");
            }
            Console.ReadKey();
        }
    }
}
