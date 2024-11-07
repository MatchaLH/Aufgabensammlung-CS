using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl eingeben: ");
            string zahl = Console.ReadLine();
            int monat = Convert.ToInt32(zahl);

            if (monat < 1 || monat > 12)
            {
                Console.WriteLine("Die eingegebene Zahl muss von 1-12 sein!");
            }
            switch (monat)
            {
                case 1: Console.WriteLine("Januar"); break;
                case 2: Console.WriteLine("Februar"); break;
                case 3: Console.WriteLine("März"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("Mai"); break;
                case 6: Console.WriteLine("Juni"); break;
                case 7: Console.WriteLine("Juli"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("Oktober"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("Dezember"); break;
            }
            Console.ReadKey();
        }
    }
}
