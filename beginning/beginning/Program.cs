using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random_zahl = r.Next(0, 100);

            Console.WriteLine("Rate meine zahl!");



            //bool du_hast_gewonnen = false;
            int geratene_zahl = 0;
            do
            {
                geratene_zahl = Convert.ToInt32(Console.ReadLine());

                if (geratene_zahl == random_zahl)
                {
                    Console.WriteLine("Du hast gewonnen!");
                    //du_hast_gewonnen = true;

                }
                else if (geratene_zahl > random_zahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner als die eingegebene Zahl");
                }
                else
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer als die eingegebene Zahl!");
                }
            } while (geratene_zahl != random_zahl);

            Console.WriteLine(random_zahl);
            Console.ReadLine();
            
        }
    }
}
