using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public class Dreieck : IGeometry
    {
        public Dreieck(int seite1, int seite2, int seite3)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }

        public int Seite1 { get; set; }
        public int Seite2 { get; set; }

        //Hypothenuse
        public int Seite3 { get; set; }

        public float Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }

        public float Flaeche()
        {
            return 2;
        }
    }
}
