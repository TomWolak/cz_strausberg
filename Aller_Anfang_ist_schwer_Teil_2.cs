using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aller_Anfang_ist_schwer_Teil_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ergebnis = 0;

            Console.WriteLine("Löse der Aufagebe 128 * 512");
            Console.ReadLine();

            for (int i = 128; i <= 128 * 512; i++)
            {
                ergebnis = i;
                Console.WriteLine(ergebnis);

            }

            Console.WriteLine("Das Ergebnis der Aufgabe 128 * 512 beträgt: " + ergebnis);

            Console.ReadLine();
        }
    }
}
