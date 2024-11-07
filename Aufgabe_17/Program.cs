using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib dein Geburtsdatum ein: ");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.Write("Alter in Jahren: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int month = age / 12;
            Console.WriteLine("Alter in Monaten: " + month);

            int week = month / 4;
            Console.WriteLine("Alter in Wochen: " + week);

            int days = week / 7;
            Console.WriteLine("Alter in Tagen: " + days);
            


        }
    }
}
