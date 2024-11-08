using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double output = 0;
            Console.WriteLine("Mach deine Berechnung");
            string eingabe = Console.ReadLine();
            eingabe = eingabe.Trim();
            if (eingabe.Contains("+"))
            {
                output = Rechner(eingabe, '+');
            }
            else if (eingabe.Contains("*"))
            {
                output = Rechner(eingabe, '*');
            }
            else if (eingabe.Contains("-"))
            {
                output = Rechner(eingabe, '-');
            }
            else if (eingabe.Contains("/"))
            {
                output = Rechner(eingabe, '/');
            } 
            Console.WriteLine(output);

        }
        static double Rechner(string eingabe, char aktion)
        {
            string[] mathe = eingabe.Split(aktion);
            double[] zahlen = new double[mathe.Length];
            double rückgabe = 0;
            for (int i = 0; i < mathe.Length; i++)
            {
                zahlen[i] = Convert.ToDouble(mathe[i]);
            }
            switch (aktion) 
            {
                case '+': rückgabe = zahlen[0] + zahlen[1]; break;
                case '*': rückgabe = zahlen[0] * zahlen[1]; break;
                case '-': rückgabe = zahlen[0] - zahlen[1]; break;
                case '/': rückgabe = zahlen[0] / zahlen[1]; break;
            }
            return rückgabe;

        }

    }
}
