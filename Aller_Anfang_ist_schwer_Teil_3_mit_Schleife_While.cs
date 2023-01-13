using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aller_Anfang_ist_schwer_Teil_3_mit_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ergebnis = 0;
            int zahl_512 = 512;

            Console.WriteLine("128 * 512 Löse der Aufagebe, mit Schleife 'while' und Bedingung 60000   Drücke <Entter>");
            Console.ReadLine();

            while(ergebnis < 60000)
            {
                ergebnis += zahl_512;
                Console.WriteLine(ergebnis);
            }
            

            Console.WriteLine("Die 'while' Schleife ist mit dem Wert: " + ergebnis + " beendet");

            Console.ReadLine();


        }
    }
}
