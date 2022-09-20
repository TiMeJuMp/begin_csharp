using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public abstract class Vehicle
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }

        public bool MotorLauft { get; private set; }
        public int Geschwindigkeit { get; private set; }

        public void Starten()
        {
            if (MotorLauft == true)
            {
                Console.WriteLine("Motor läuft schon, kann ihn nicht starten!");
            }
            else
            {
                MotorLauft = true;
                Console.WriteLine("Motor wird gestartet!.. WRRRUUMMMM");
            }
        }
        public void Beschleunigen()
        {
            Geschwindigkeit += 10;
        }

        public void Bremsen()
        {
            if (Geschwindigkeit <= 0)
            {
                Console.WriteLine($"{this.GetType().Name} steht bereits!");
            }
            else
            {
                Geschwindigkeit -= 10;
                Console.WriteLine($"{this.GetType().Name} wird gebremst");
            }
        }
    }
}
