using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Dolgozo : IPrint
    {
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public int AdoSzam { get; private set; }
        public float AlapFizetes { get; private set; }

        public Dolgozo(string nev, string cim, int adoSzam, float alapFizetes)
        {
            this.Nev = nev;
            this.Cim = cim;
            this.AdoSzam = adoSzam;
            this.AlapFizetes = alapFizetes;
        }

        public virtual string Print()
        {
            return Nev + ", " + Cim;
        }


    }
}
