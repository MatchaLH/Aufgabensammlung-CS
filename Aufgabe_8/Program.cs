using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] woerter = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };
            int counter = 0;

            Console.WriteLine("Dein Kommentar:");
            string comment = Console.ReadLine();

            for (int i = 0; i < woerter.Length; i++)
            {
                if (comment.Contains(woerter[i]))
                {
                    counter += 1;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine("Dein Kommentar enthält {0} verbotene Wörter.", counter);
                Console.WriteLine("Er wird nicht veröffentlicht.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar.");
            }
        }
    }
}
