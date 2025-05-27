using System;
using System.Security.Cryptography.X509Certificates;

namespace consoleAppKajak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kolcsonzesek = new List<Kenu>();
            var sorok = File.ReadAllLines(@"..\..\..\kolcsonzes.txt").Skip(1);

            foreach (var sor in sorok)
            {
                kolcsonzesek.Add(new Kenu(sor));
            }

            Console.WriteLine($"4. feladat\nKölcsönzések száma: {kolcsonzesek.Count}");

            Console.Write("\n5. feladat\nKérem egy kölcsönző nevét: ");
            var keresettNev = Console.ReadLine();

            var talalatok = kolcsonzesek
                .Where(k => k.Nev == keresettNev)
                .ToList();

            if (talalatok.Any())
            {
                Console.WriteLine($"{keresettNev} kölcsönzései:");
                foreach (var t in talalatok)
                {
                    Console.WriteLine($"{t.ElvitelOra}:{t.ElvitelPerc} - {t.VisszaOra}:{t.VisszaPerc}");
                }
            }
            else
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
            }

            var magyarok = kolcsonzesek
                .Count(k => !k.Nev.Contains(","));

            var kulfoldiek = kolcsonzesek
                .Count(k => k.Nev.Contains(","));

            Console.WriteLine($"\n6. feladat\nMagyarok: {magyarok}, Külföldiek: {kulfoldiek}");

            ////DOLGOZAT innentől////
            //1. feladat
            Console.WriteLine("\nDolgozat feladatok következnek");
            Console.WriteLine("\n1. feladat\nHajók óránkénti kölcsönzése:");

            var oraCsoportok = kolcsonzesek
                .GroupBy(k => k.ElvitelOra)
                .OrderBy(g => g.Key); 
            
            foreach (var oraCsoport in oraCsoportok)
            {
                Console.WriteLine($"{oraCsoport.Key}h - {oraCsoport.Count()} hajó");
            }

            //3. feladat
            Console.WriteLine("\n 3. feladat\n Kérem a hajó azonosítóját: ");
            var HajoAzonsoito = Console.ReadLine();

            Console.WriteLine("Kérem a hajó típusát: ");
            var HajoTipus = Console.ReadLine();

            Console.WriteLine("Kérem a személyek számát: ");
            var SzemelyekSzama = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter("kiieretedmenyek.txt"))
            {
                //if (HajoAzonsoito && HajoTipus && SzemelyekSzama == null)
                //{

                //}
                //sw.WriteLine("");
            }
            //Utolsó kölcsönzési időpont kiírva
            //Console.WriteLine($"{t.ElvitelOra}:{t.ElvitelPerc}");
        }
    }
}