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
            Console.WriteLine("Gib mir ein Wort!");
            string entry = Console.ReadLine();

            string replaced_entry = entry.Replace("Umd", "Gmc").Replace("u", "g");

            Console.WriteLine("Der alte Text war " + entry);
            Console.WriteLine("Der neue Text is " + replaced_entry);
            
            Console.ReadLine();
        }
    }
}
