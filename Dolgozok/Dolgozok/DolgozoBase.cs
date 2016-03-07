using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    abstract class DolgozoBase
    {
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public int AdoSzam { get; private set; }
        public float AlapFizetes { get; private set; }

        public DolgozoBase(string nev, string cim, int adoSzam, float alapFizetes)
        {
            this.Nev = nev;
            this.Cim = cim;
            this.AdoSzam = adoSzam;
            this.AlapFizetes = alapFizetes;
        }

        public new string ToString()
        {
            return "Dologzo: " + Nev + ", " + Cim;
        }
    }
}
