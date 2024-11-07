using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie eine Ganzzahl ein  :");
            var ganzZahl = Convert.ToInt32(Console.ReadLine());
            int sum = berechneQuersumme(ganzZahl);

            Console.WriteLine("Die Quersumme ist    :" + sum);
            Console.ReadKey();

        }

        static int berechneQuersumme(int zahl)
        {
            int sum = 0;
            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            return sum;

        }
    }
}
