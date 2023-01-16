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
            int zahl_A = 128;
            int zahl_B = 512;

            Console.WriteLine("128 * 512 Löse der Aufagebe  <Drücke Enter>");
            Console.ReadLine();

            for (int i = 0; i < zahl_A; ++i)
            {
                ergebnis = ergebnis + zahl_B;
                Console.WriteLine("{0} {1}", i, ergebnis);

            }

            Console.WriteLine("Das Ergebnis der Aufgabe 128 * 512 beträgt: " + ergebnis);

            Console.ReadLine();
        }
    }
}
