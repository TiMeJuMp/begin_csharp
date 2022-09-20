using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public class Rechteck : IGeometry
    {
        public Rechteck(int seite1, int seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }

        public int Seite1 { get; set; }
        public int Seite2 { get; set; }

        public float Flaeche()
        {
            return Seite1 * Seite2;
        }
        public float Umfang()
        {
            return 2 * (Seite1 + Seite2);
        }
    }
}
