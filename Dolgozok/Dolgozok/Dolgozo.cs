using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Dolgozo : DolgozoBase
    {

        public Dolgozo(string nev, string cim, int adoSzam, float alapFizetes) : base(nev, cim, adoSzam, alapFizetes)
        {
        }

        public virtual float Fizetes()
        {
            return AlapFizetes;
        }

        public new string ToString()
        {
            return "Dologzó, a gazdasági osztály: " + AdoSzam + ", " + Fizetes();
        }
    }
}
