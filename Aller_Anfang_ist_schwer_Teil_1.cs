using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aller_Anfang_ist_schwer_Teil_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    // Deklarieren und Initialisieren der benötigten Variablen
                    double zahl_A, zahl_B, add_Erg, sub_Erg, mul_Erg, div_Erg, all_Erg;

                    Console.WriteLine("Aller Anfang ist schwer Teil 1");

                    Console.WriteLine();
                    // Eingabe auf der Konsole
                    Console.WriteLine("Geben Sie die erste Zahl ein: ");
                    zahl_A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Geben Sie die zweite Zahl ein: ");
                    zahl_B = Convert.ToDouble(Console.ReadLine());

                    add_Erg = zahl_A + zahl_B;
                    Console.WriteLine("Addition Ergebnis: " + add_Erg);

                    sub_Erg = zahl_A - zahl_B;
                    Console.WriteLine("Subtraktion Ergebnis: " + sub_Erg);

                    mul_Erg = zahl_A * zahl_B;
                    Console.WriteLine("Multiplikation Ergebnis: " + mul_Erg);

                    if(zahl_B == 0)
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt!");
                    }
                    else
                    {
                        div_Erg = zahl_A / zahl_B;
                        Console.WriteLine("Division Ergebnis: " + div_Erg);
                    }
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Error! Geben Sie einen numerischen Wert ein");
            }
            Console.ReadLine();
        }
    }
}
