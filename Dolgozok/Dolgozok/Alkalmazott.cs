using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Alkalmazott : Dolgozo
    {
        public int BelsoAzonosito { get; private set; }
        public string Beosztas { get; private set; }
        public float TuloraDij { get; private set; }
        public int Tulorak { get; private set; }

        public Alkalmazott(string nev, string cim, int adoSzam, float alapFizetes, int belsoAz, string beosztas, float tuloraDij, int tulorak) : 
            base(nev, cim, adoSzam, alapFizetes)
        {
            this.BelsoAzonosito = belsoAz;
            this.Beosztas = beosztas;
            this.TuloraDij = tuloraDij;
            this.Tulorak = tulorak;
        }

        public override float Fizetes()
        {
            return base.Fizetes()+ Tulorak * TuloraDij;
        }

        public new string Print()
        {
            return Beosztas + ", " +Nev;
        }
    }
}
