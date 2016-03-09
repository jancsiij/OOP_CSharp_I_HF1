using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
     class Alvalalkozo : Dolgozo, IComparable
    {
        public DateTime SzerzodesVege { get; private set; }
        public string Feladat { get; private set; }
        public int SikerDij { get; private set; }

        public Alvalalkozo(string nev, string cim, int adoSzam, float alapFizetes, DateTime szerzodesVege, string feladat, int sikerDij) :
            base(nev, cim, adoSzam, alapFizetes)
        {
            this.SzerzodesVege = szerzodesVege;
            this.Feladat = feladat;
            this.SikerDij = sikerDij;
        }

        public override float Fizetes()
        {
            return base.Fizetes() + SikerDij;
        }

        public new string Print()
        {
            return SzerzodesVege + ", " + Nev;
        }

        public int CompareTo(object obj)
        {
            
            Alvalalkozo other = obj as Alvalalkozo;

            if (SzerzodesVege >= other.SzerzodesVege)
            {
                return Nev.CompareTo(other.Nev);
            }
            return -1;
        }
    }
}
