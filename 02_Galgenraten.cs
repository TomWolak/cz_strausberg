using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Galgenraten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wort wort = new Wort("madagaskar");
            int maxAnzahlProbe = 10;
            int verwendetProbe = 0;
            bool obGeloest = false;
            Console.WriteLine("Das geheimes Lösungswort hat so viele Buchstaben ");
            try
            {
                while (verwendetProbe < maxAnzahlProbe)
                {
                    Console.WriteLine("                      " + wort.Entnehmen());
                    Console.WriteLine("Erraten Sie einen Buchstabe!    <" + verwendetProbe + " Versuche bereits verwendet>");
                    char benutzerBuchstabeAntwort = Convert.ToChar(Console.ReadLine());
                    char benutzerBuchstabeAntwort_ToLower = Char.ToLower(benutzerBuchstabeAntwort);
                    wort.ErratenBuchstabe(benutzerBuchstabeAntwort_ToLower);
                    if (wort.ObErraten())
                        break;

                    Console.WriteLine(wort.Entnehmen());
                    Console.WriteLine("Jetzt können Sie das ganze Wort versuchen zu erraten!");
                    string benutzerWortAntwort = Convert.ToString(Console.ReadLine());
                    obGeloest = benutzerWortAntwort == wort.EntnehmenOeffentlich();
                    if (obGeloest)
                        break;

                    verwendetProbe++;
                    Console.Clear();
                }
                if (wort.ObErraten() || obGeloest)
                {
                    Console.Clear();
                    Console.WriteLine("!!! You Win !!!");
                    Console.WriteLine("Das geheimes Lösungswort ist " + wort.EntnehmenOeffentlich());
                }
                else
                {
                    Console.WriteLine("You Lost the Game!");
                    Console.WriteLine("Versuche es noch einmal");
                }

                Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();
        }

        public class Wort
        {
            public List<BuchstabeEinesWortes> ListeDerBuchstaben;

            public Wort(string wort)  
            {
                ListeDerBuchstaben = new List<BuchstabeEinesWortes>();  
                                                      
                foreach (char c in wort)
                {
                    BuchstabeEinesWortes a = new BuchstabeEinesWortes(c); 
                    ListeDerBuchstaben.Add(a); 
                }
            }

            public bool ObErraten() 
            {
                foreach (BuchstabeEinesWortes a in ListeDerBuchstaben)
                {
                    if (a.ist_erraten == false)  
                    {
                        return false;
                    }
                }
                return true;
            }

            public string Entnehmen() 
            {
                string aufschrift = "";
                foreach (BuchstabeEinesWortes a in ListeDerBuchstaben)
                {
                    if (a.ist_erraten == true)
                    {
                        aufschrift = aufschrift + a.buchstabe;
                    }
                    else
                    {
                        aufschrift = aufschrift + "*";
                    }
                }
                return aufschrift;
            }

            public void ErratenBuchstabe(char zeichen) 
            {
                foreach (BuchstabeEinesWortes eb_buchstabe in ListeDerBuchstaben)
                {
                    if (zeichen == eb_buchstabe.buchstabe)
                    {
                        eb_buchstabe.ist_erraten = true;   
                    }
                }
            }

            public string EntnehmenOeffentlich() 
            {
                string aufschrift = "";
                foreach (BuchstabeEinesWortes eo_buchstabe in ListeDerBuchstaben)
                {
                    aufschrift = aufschrift + eo_buchstabe.buchstabe;
                }
                return aufschrift;
            }
        }

        public class BuchstabeEinesWortes    
        {
            public char buchstabe;         
            public bool ist_erraten;

            public BuchstabeEinesWortes(char bew_buchstabe)
            {
                this.buchstabe = bew_buchstabe;
                this.ist_erraten = false;
            }
        }
    }
}

/*
    public class Wort - eine Klasse mit Methoden
    Wort(string wort) - ein Konstruktor
    wort - ein Objekt der Klasse Wort
    Entnehmen()  - eine Methode der Klasse Wort 
    ErratenBuchstabe() - eine Methode der Klasse Wort
    ObErraten() - eine Methode der Klasse Wort
    EntnehmenOeffentlch() - eine Methode der Klasse Wort

    BuchstabeEinesWortes - eine Klasse 

    ListeDerBuchstaben - container


*/