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
            Console.WriteLine("Wir holen uns jetzt eine Zahl aus Number()");
            List<string> names = Number();
            foreach (var name in names)
            {
                Console.WriteLine(names);
            }
            Console.ReadLine();

        }

        //static  Rückgabetyp   Name  (Parameter)
        static List<string> Number()
        {
            List<string> name = new List<string>();
            name.Add("ABC");

            //Rückgabevariable
            return name;
        }
    }
}
