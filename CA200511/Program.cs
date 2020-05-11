using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200511
{
    class Program
    {
        static Random rnd = new Random();
        static List<Hal> halak;
        static void Main(string[] args)
        {
            Feltolt(100);
            OsszesKiir();

            Console.ReadKey();
        }

        private static void OsszesKiir()
        {
            foreach (var h in halak)
            {
                Console.WriteLine("{0, -9} {1, 10} {2, 5} Kg él: [{3} - {4}]",
                    h.Ragadozo ? "ragadozó" : "növényevő",
                    h.Faj, 
                    h.Suly,
                    h.MinMelyseg, 
                    h.MinMelyseg + h.Merules);
            }
        }

        private static void Feltolt(int db)
        {
            halak = new List<Hal>();

            for (int i = 0; i < db; i++)
            {
                halak.Add(new Hal()
                {
                    Ragadozo = rnd.Next(100) >= 90,
                    Suly = rnd.Next(5, 400) / 10F,
                    MinMelyseg = rnd.Next(400),
                    Merules = rnd.Next(10, 400),
                    Faj = Hal.Fajtak[rnd.Next(Hal.Fajtak.Length)],
                });
            }
        }
    }
}
