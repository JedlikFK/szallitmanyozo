using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallitmanyozas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rendszamok = {"ABC-123","ABC-124", "ABC-125", "ABC-126", "ABC-127", "ABC-128", "ABC-129", "ABC-130", "ABC-131", "ABC-132"};
            List<string> bent = new List<string>();
            string valasztas;
            do
            {
                Console.WriteLine("Kimegy (K)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (Q)");
                //A választási lehetőségek
                valasztas = Console.ReadLine();
                //A választás bekérés
                switch (valasztas)
                {
                    case "K":kimegy(); break;
                    case "B":bejon(rendszamok, bent); break;
                    case "Q":kilepes(); break;
                    default: Console.WriteLine("nem megfelelő válastás"); break;
                }
            } while (valasztas!="Q");
            Console.ReadKey();
        }

        private static void kimegy()
        {
            throw new NotImplementedException();
        }

        private static void kilepes()
        {
            throw new NotImplementedException();
        }

        static void bejon(string[] rendszamok, List<string> bent)
        {
            Console.WriteLine($"Jelenleg {bent.Count} autó van a telepen.");
            foreach (var item in bent)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Adja meg a rendszámot:");
            bool tartalmaz = false;
            bool bentvan = false;
            string megadott = Console.ReadLine();
            if (rendszamok.Contains(megadott))
            {
                tartalmaz = true;
                Console.WriteLine("A rendszám bent van az adatbázisban");
            }
            else
            {
                Console.WriteLine("Nincs bent az adatbázisban");
            }
            for (int i = 0; i < bent.Count; i++)
            {
                if (megadott==rendszamok[i])
                {
                    bentvan = true;
                    Console.WriteLine("Az autó bent van a telepen nem jöhet be!");
                    break;
                }
            }
            if (tartalmaz&&!bentvan)
            {
                bent.Add(megadott);
                Console.WriteLine("Hozzá adva a bent lévő autókhoz.");
            }
        }
    }
}
