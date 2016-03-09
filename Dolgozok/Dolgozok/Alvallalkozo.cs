using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
     class Alvallalkozo : Dolgozo, IComparable
    {
        public DateTime SzerzodesVege { get; private set; }
        public string Feladat { get; private set; }
        public int SikerDij { get; private set; }

        public Alvallalkozo(string nev, string cim, int adoSzam, float alapFizetes, DateTime szerzodesVege, string feladat, int sikerDij) :
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
            return SzerzodesVege.ToShortDateString() + ", " + Nev;
        }

        public int CompareTo(object obj)
        {
            
            Alvallalkozo other = obj as Alvallalkozo;

            if (SzerzodesVege >= other.SzerzodesVege)
            {
                return Nev.CompareTo(other.Nev);
            }
            return -1;
        }
    }
}
