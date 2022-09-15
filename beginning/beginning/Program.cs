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
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Du kommscht hier net rein!");
            }
            else
            {
                Console.WriteLine("Viel Spaß!");

            }
            Console.ReadLine();
        }
    }
}
