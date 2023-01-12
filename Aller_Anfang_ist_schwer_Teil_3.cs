using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aller_Anfang_ist_schwer_Teil_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ergebnis = 0;
            int produkt = 128 * 512;

            Console.WriteLine("Löse der Aufagebe 128 * 512");
            Console.ReadLine();

            for (int i = 128; i <= produkt; i++)
            {
                ergebnis = i;
                Console.WriteLine(ergebnis);
                
                if (i > 60000)
                {
                    i = produkt;
                }
            }

            Console.WriteLine("Die 'for' Schleife ist mit dem Wert: " + ergebnis + " beendet");

            Console.ReadLine();

        }
    }
}
