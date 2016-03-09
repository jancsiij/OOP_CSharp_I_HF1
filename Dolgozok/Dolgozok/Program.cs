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
            #region init
            List<Dolgozo> dolgozok = new List<Dolgozo>();
            dolgozok.Add(new Dolgozo("Klára", "Kecskemét", 11113, 90000));
            dolgozok.Add(new Dolgozo("Kata", "Kiskunasdasd", 11114, 100000));
            dolgozok.Add(new Dolgozo("Kriszti", "Káva", 11115, 80000));
            dolgozok.Add(new Dolgozo("Kalap", "Kalapács", 11116, 70000));
            dolgozok.Add(new Dolgozo("K", "Ki", 11117, 60000));

            List<Alvallalkozo> alvalalkozok = new List<Alvallalkozo>();
            
            alvalalkozok.Add(new Alvallalkozo("Alfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200));
            alvalalkozok.Add(new Alvallalkozo("cAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200));
            alvalalkozok.Add(new Alvallalkozo("BAlfonz", "Budapest", 100000, 10000, new DateTime(2015, 11, 11), "szipu", 200));
            alvalalkozok.Add(new Alvallalkozo("ZAlfonz", "Budapest", 100000, 10000, new DateTime(2016, 11, 11), "szipu", 200));
            alvalalkozok.Add(new Alvallalkozo("BAlfonz", "Budapest", 100000, 10000, new DateTime(2014, 11, 11), "szipu", 200));

            List<Alkalmazott> alkalmazottak = new List<Alkalmazott>();
            alkalmazottak.Add(new Alkalmazott("Ferenc", "Sásd", 111114, 40000, 13, "Utcaseprő", 500, 2));
            alkalmazottak.Add(new Alkalmazott("Flórián", "Sakk", 111114, 40000, 13, "Kéményseprő", 500, 2));
            alkalmazottak.Add(new Alkalmazott("Fanta", "Sitt", 111114, 40000, 13, "Tetőseprő", 500, 2));
            alkalmazottak.Add(new Alkalmazott("Fila", "Sott", 111114, 40000, 13, "Asztalseprő", 500, 2));
            alkalmazottak.Add(new Alkalmazott("Fun", "Sál", 111114, 40000, 13, "Utcaseprő", 500, 2));

            List<Kiszervezett> kiszervezettek = new List<Kiszervezett>();
            kiszervezettek.Add(new Kiszervezett("Alba", "Pécs", 111112, 200000, "asd", "Matro", 40000));
            kiszervezettek.Add(new Kiszervezett("Feri", "Pécs", 111112, 200000, "asd", "Batro", 40000));
            kiszervezettek.Add(new Kiszervezett("Teve", "Pécs", 111112, 200000, "asd", "Matro", 40000));
            kiszervezettek.Add(new Kiszervezett("Doge", "Pécs", 111112, 200000, "asd", "Zatro", 40000));
            kiszervezettek.Add(new Kiszervezett("Kenny", "Pécs", 111112, 200000, "asd", "Aatro", 40000));

            #endregion

            Console.WriteLine("\nDolgozók listája");
            foreach (Dolgozo item in dolgozok) 
            {
                Console.WriteLine(item.Print());
            }

            Console.WriteLine("\nAlkalmazottak listája");
            foreach (Alkalmazott item in alkalmazottak)
            {
                Console.WriteLine(item.Print());
            }

            Console.WriteLine("\nAlvállalkozók listája");
            foreach (Alvallalkozo item in alvalalkozok)
            {
                Console.WriteLine(item.Print());
            }

            Console.WriteLine("\nKiszervezettek listája");
            foreach (Kiszervezett item in kiszervezettek)
            {
                Console.WriteLine(item.Print());
            }

            
            Console.WriteLine("\n----Rendezett listák----");

            alvalalkozok.Sort();
            Console.WriteLine("\nRendezett Alválalkozók");
            foreach (Alvallalkozo item in alvalalkozok)
            {
                Console.WriteLine(item.Print());
            }

            kiszervezettek.Sort();
            Console.WriteLine("\nRendezett Kiszervezettek");
            foreach (Kiszervezett item in kiszervezettek)
            {
                Console.WriteLine(item.Print());
            }


            Console.WriteLine("\n----Listák----\n");
            Console.WriteLine("Név, cím");

            List<DolgozoBase> vegyesDolgozok = new List<DolgozoBase>();
            vegyesDolgozok.AddRange(dolgozok);
            vegyesDolgozok.AddRange(alkalmazottak);
            vegyesDolgozok.AddRange(alvalalkozok);
            vegyesDolgozok.AddRange(kiszervezettek);

            foreach (Dolgozo item in vegyesDolgozok)
            {
                Console.WriteLine(item.Print());
            }

            Console.WriteLine();
            Console.WriteLine("Név, pontos fizetés");

            foreach (DolgozoBase item in vegyesDolgozok)
            {
                Console.WriteLine(item.Print());

            }

            Console.ReadKey();
        }
    }
}
