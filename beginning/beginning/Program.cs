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
            int zahl1 = 121;
            int zahl2 = 5;

            int ergebnis = Add(zahl1, zahl2);

            double divideResult = Divide((double)zahl1, (double)zahl2);
            Console.WriteLine(ergebnis);
            Console.WriteLine(divideResult);
            Console.ReadLine();

        }

        static int Add(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }
        static int Divide(int z1, int z2)
        {
            int ergbnis = z1 / z2;
            return ergbnis;
        }

        static double Divide(double z1, double z2)
        {
            double ergebnis = z1 / z2;
            return ergebnis;
        }

        //static  Rückgabetyp   MethodenName  (Parameter)
        static List<string> Number()
        {
            List<string> name = new List<string>();
            name.Add("ABC");

            //Rückgabevariable
            return name;
        }
    }
}
