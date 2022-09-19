using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public class Car
    {
        public int TypeId { get; set; }
        public string Make { get; set;}
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }

        public Car(int typeId, string make, string model, string typeName, int cCM, string color, int tyres)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            CCM = cCM;
            Color = color;
            Tyres = tyres;
        }

        public void PrintCarInformation()
        {
            Console.WriteLine($"Mein Fahrzeug ist ein " +
                $"{Make} {Model} {TypeName} mit einem Hubraum von " +
                $"{CCM} in der Farbe {Color} mit {Tyres} Reifen");
        }
    }
}
