﻿using System;
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
            Alvalalkozo alv3 = new Alvalalkozo("BAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200);
            Alvalalkozo alv4 = new Alvalalkozo("ZAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200);
            Alvalalkozo alv5 = new Alvalalkozo("BAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200);
            Kiszervezett kisz1 = new Kiszervezett("Rekt", "Pécs", 111112, 200000, "asd", "Matro", 40000);

            List<DolgozoBase> AlapDolgozok = new List<DolgozoBase>();
            AlapDolgozok.Add(dolg1);
            AlapDolgozok.Add(alk1);
            AlapDolgozok.Add(alv1);
            AlapDolgozok.Add(kisz1);



            List<Alvalalkozo> Alvalalkozok = new List<Alvalalkozo>();

            Alvalalkozok.Add(alv1);
            Alvalalkozok.Add(alv2);
            Alvalalkozok.Add(alv3);
            Alvalalkozok.Add(alv4);

            List<Alvalalkozo> RendezettAlvalalkozok = Alvalalkozok.OrderBy(x => x.SzerzodesVege).ThenBy(x => x.Nev).ToList();

            foreach (Dolgozo item in RendezettAlvalalkozok)
            {
                Console.WriteLine(item.ToString());

            }
            Console.WriteLine();

            foreach (var item in AlapDolgozok)
            {
                Console.WriteLine(item.ToString());
            }

            List<Dolgozo> Dolgozok = new List<Dolgozo>();
            Dolgozok.Add(dolg1);
            Dolgozok.Add(alk1);
            Dolgozok.Add(alv1);
            Dolgozok.Add(kisz1);

            foreach (var item in Dolgozok)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadKey();
        }
    }
}
