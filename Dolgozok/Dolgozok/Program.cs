using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolgozo dolg1 = new Dolgozo("Klára", "Kecskemét", 11113, 90000);
            Alkalmazott alk1 = new Alkalmazott("Ferenc", "Sásd", 111114, 40000, 13, "Utcaseprő", 500, 2);
            Alvalalkozo alv1 = new Alvalalkozo("Alfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200);
            Alvalalkozo alv2 = new Alvalalkozo("cAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200);
            Alvalalkozo alv3 = new Alvalalkozo("BAlfonz", "Budapest", 100000, 10000, new DateTime(2015, 11, 11), "szipu", 200);
            Alvalalkozo alv4 = new Alvalalkozo("ZAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200);
            Alvalalkozo alv5 = new Alvalalkozo("BAlfonz", "Budapest", 100000, 10000, new DateTime(2014, 11, 11), "szipu", 200);
            Kiszervezett kisz1 = new Kiszervezett("Alba", "Pécs", 111112, 200000, "asd", "Matro", 40000);
            Kiszervezett kisz2 = new Kiszervezett("Feri", "Pécs", 111112, 200000, "asd", "Batro", 40000);
            Kiszervezett kisz3 = new Kiszervezett("Teve", "Pécs", 111112, 200000, "asd", "Matro", 40000);
            Kiszervezett kisz4 = new Kiszervezett("Doge", "Pécs", 111112, 200000, "asd", "Csatro", 40000);
            Kiszervezett kisz5 = new Kiszervezett("Kenny", "Pécs", 111112, 200000, "asd", "atro", 40000);


            List<Kiszervezett> kiszervezettek = new List<Kiszervezett>();
            kiszervezettek.Add(kisz1);
            kiszervezettek.Add(kisz2);
            kiszervezettek.Add(kisz3);
            kiszervezettek.Add(kisz4);
            kiszervezettek.Add(kisz5);

            List<DolgozoBase> dolgozok = new List<DolgozoBase>();
            dolgozok.Add(dolg1);
            dolgozok.Add(alk1);
            dolgozok.Add(alv1);
            dolgozok.Add(kisz1);

            List<Alvalalkozo> Alvalalkozok = new List<Alvalalkozo>();
            Alvalalkozok.Add(alv1);
            Alvalalkozok.Add(alv2);
            Alvalalkozok.Add(alv3);
            Alvalalkozok.Add(alv4);

            kiszervezettek.Sort();
            Console.WriteLine("Rendezett Kiszervezettek");
            foreach (Kiszervezett item in kiszervezettek)
            {
                Console.WriteLine(item.Print());
            }


            Alvalalkozok.Sort();
            Console.WriteLine("Rendezett Alválalkozók");
            foreach (Alvalalkozo item in Alvalalkozok)
            {
                Console.WriteLine(item.Print());
            }

            //List<Alvalalkozo> RendezettAlvalalkozok = Alvalalkozok.OrderBy(x => x.SzerzodesVege).ThenBy(x => x.Nev).ToList();

            Console.WriteLine("Név, cím");

            foreach (Dolgozo item in dolgozok)
            {
                Console.WriteLine(item.Print());
            }

            Console.WriteLine();
            Console.WriteLine("Név, pontos fizetés");

            foreach (DolgozoBase item in dolgozok)
            {
                Console.WriteLine(item.Print());

            }




            Console.ReadKey();
        }
    }
}
