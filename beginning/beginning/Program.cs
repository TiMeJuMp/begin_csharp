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

            string substring_entry = entry.Substring(3, 4);

            Console.WriteLine("Old entry: " + entry);
            Console.WriteLine("New entry: " + substring_entry);

            Console.ReadLine();
        }
    }
}
