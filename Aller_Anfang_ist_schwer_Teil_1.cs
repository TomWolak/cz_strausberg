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
                    Console.WriteLine("Addition Ergebnis: " + Math.Round(add_Erg, 2));

                    sub_Erg = zahl_A - zahl_B;
                    Console.WriteLine("Subtraktion Ergebnis: " + Math.Round(sub_Erg, 2));

                    mul_Erg = zahl_A * zahl_B;
                    Console.WriteLine("Multiplikation Ergebnis: " + Math.Round(mul_Erg, 2));

                    if(zahl_B == 0)
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt!");
                    }
                    else
                    {
                        div_Erg = zahl_A / zahl_B;
                        Console.WriteLine("Division Ergebnis: " + Math.Round(div_Erg, 2));
                    }

                    if (zahl_B == 0)
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt!");
                    }
                    else
                    {
                        all_Erg = ((zahl_A + zahl_B) * zahl_A / zahl_B) - zahl_A;
                        Console.WriteLine("Gemischt Ergebnis: " + Math.Round(all_Erg, 2));
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
