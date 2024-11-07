using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            for (int i1 = 0; i1 < eingabe; i1++)
            {
                for (int i2 = 0; i2 < eingabe; i2++)
                {
                    if (i1 != i2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }  
    }
}
