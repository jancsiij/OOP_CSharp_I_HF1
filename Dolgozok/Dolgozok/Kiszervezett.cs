using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Kiszervezett :Dolgozo, IComparable
    {
        public string Munkakor { get; private set; }
        public string Munkaltato { get; private set; }
        public int MuszakPotlek { get; private set; }

        public Kiszervezett(string nev, string cim, int adoSzam, float alapFizetes, string munkakor, string munkaltato, int muszakpotlek) : 
            base(nev, cim, adoSzam, alapFizetes)
        {
            this.Munkakor = munkakor;
            this.MuszakPotlek = muszakpotlek;
            this.Munkaltato = munkaltato;
        }

        public override float Fizetes()
        {
            return base.Fizetes() + MuszakPotlek;
        }

        public new string Print()
        {
            return Munkaltato +" "+ Nev;
        }

        public int CompareTo(object obj)
        {
            Kiszervezett other = obj as Kiszervezett;
            if(Munkaltato.CompareTo(other.Munkaltato) >= 0)
            {
                return Nev.CompareTo(other.Nev);
            }
            return -1;
        }
    }
}
