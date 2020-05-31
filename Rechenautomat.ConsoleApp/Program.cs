using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechenautomat.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (string eingabe = "-"; eingabe != "";) 
            {
                try
                {
                    Random a = new Random();
                    int punkte = 0;
                    int erg = 0;
                   
                   
                    int zahl1 = a.Next(1, 11);
                    int zahl2 = a.Next(1, 11);
                    Console.Write("Möchten Sie lieber mit Negativen oder Positiven zahlen rechnen");
                    string eingabe1 = Convert.ToString(Console.ReadLine());

                    
                    if(eingabe1 == "positiv")
                    {
                        Console.WriteLine("Rechnung:", zahl1 + zahl2 == erg);
                        string erg1 = Convert.ToString(erg);

                        if(eingabe == erg1)
                        {
                            punkte = punkte++;
                        }
                        else
                        {
                            Console.WriteLine("Leider war die Antwort war falsch", punkte); 
                        }
                    } 

                    else if(eingabe1 == "negativ")
                    {
                        Console.WriteLine("Rechnung:", zahl1 - zahl2 == erg);
                        string erg1 = Convert.ToString(erg);

                        if (eingabe == erg1)
                        {
                            punkte = punkte++;
                        }
                        else
                        {
                            Console.WriteLine("Leider war die Antwort war falsch", punkte);
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
