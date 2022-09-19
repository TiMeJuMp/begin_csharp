using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(13494, "Audi","A3","2.0 TDI", 1900, "Rot", 4);


            Car c2 = new Car(56553, "Volkswagen", "Golv V", "1.9 TDI", 1890, "Grau Metallic",4);

            List<Car> cars = new List<Car>() { c1, c2};

            foreach(Car car in cars)
            {
                car.PrintCarInformation();
            }

            Console.ReadLine();
            
        }



        

    }
}
