using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int budget = 10000;
            bool wonLastRound = false;
            int einsatz = 10;
            bool zeroThrown = false;
            int runden = 0;
            int höchsteZahl = 0;
            int kleinsteZahl = 40;
            Console.WriteLine("Wir beginnen mit dem Geld verlieren!");
            while (budget > 0)
            {
                Console.WriteLine($"Dein Aktuelles Geld {budget}");
                if (zeroThrown == false)
                {
                    if (wonLastRound && budget > 10000)
                    {
                        einsatz = 10;
                    }
                    else if (!wonLastRound && budget > 10000)
                    {
                        einsatz = einsatz * 2;
                    }
                    else if (budget < 10000)
                    {
                        int verlust = 10000 - budget;
                        einsatz = verlust * 2;
                    }

                    //Setze maximal 1000$
                    einsatz = Math.Min(einsatz, 1000);
                    if (einsatz > budget)
                    {
                        einsatz = budget;
                    }
                }
                Console.WriteLine($"Wir setzen {einsatz}");

                budget = budget - einsatz;
                runden++;



                int number = r.Next(0, 37);
                if(number < kleinsteZahl)
                {
                    kleinsteZahl = number;
                }
                if(number > höchsteZahl)
                {
                    höchsteZahl = number;
                }
                Console.WriteLine($"Wir schmeißen {number}");
                zeroThrown = false;
                if (number % 2 == 0 && number != 0 ) //k gerade, gewonnen
                {
                    wonLastRound = true;
                    budget = budget + einsatz * 2;
                    einsatz = einsatz * 2;
                    Console.WriteLine($"Wir haben gewonnen {einsatz * 2}");
                }
                else if(number == 0) // k ist 0
                {
                    zeroThrown = true;
                    Console.WriteLine($"Null geschmissen, Einsatz bleibt gleich {einsatz}");
                }
                else
                {
                    Console.WriteLine($"Wir haben verloren");

                }
               // Thread.Sleep(1500);
            }
            Console.WriteLine($"Du hast nach {runden} Runden dein Geld verzockt.");
            Console.WriteLine($"Höchste Zahl {höchsteZahl}:    Kleinste Zahl: {kleinsteZahl}");
            Console.ReadLine();
        }

    }
}
