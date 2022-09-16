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

            // [   |    |    |    |    ]
            int[] zahlen = new int[5];

            // [ 26 | 8 | 12  | 3  | 6  ]
            int[] zahlen2 = new int[] { 26, 8, 12, 3, 6 };


            for(int i = 0; i< zahlen.Length; i++)
            {
                Console.WriteLine("Gebe mir eine Zahl für das Array!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("[ ");
            for(int i = 0; i<zahlen.Length; i++)
            {
                Console.Write($" {zahlen[i]}  | ");
            }
            Console.Write(" ]");

            Console.ReadLine();
            
        }
    }
}
