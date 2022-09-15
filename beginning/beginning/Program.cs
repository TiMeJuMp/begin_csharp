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
            Console.WriteLine("Wie heißt du ?");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Hello " + userName);

            Console.WriteLine("Wie alt bist du aktuell?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie alt bist du in X Jahren?");
            int nextYear = Convert.ToInt32(Console.ReadLine());
            int sumYears = age + nextYear; 
            Console.WriteLine("Du bist also in "+ nextYear + " Jahren,  " + sumYears );
            Console.ReadLine();
        }
    }
}
