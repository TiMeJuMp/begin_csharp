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
            List<Car> cars = new List<Car>() ;
            for(int i = 0; i< 3; i++)
            {
                cars.Add(Car.AskUserForCar());
            }

            foreach(Car car in cars)
            {
                car.PrintCarInformation();
            }

            Console.ReadLine();            
        }



        

    }
}
