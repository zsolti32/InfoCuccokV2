using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace monitorok
{
    class Program
    {
        static Monitor legolcsobbMonitor(List<Monitor> m)
        {
            var legolcsobb = m.OrderBy(monitor => monitor.Ara).First();
            return legolcsobb;
        }
        static double nyitoKeszlet(List<Monitor> m)
        {
            int db = 15;
            return m.Sum(m => m.BruttoAr * db);
        }

        static void Main(string[] args)
        {
            //Monitor vásár


            //Egy hardver cég többféle monitort árul. A monitorokról a következő adatokat tároljuk: a monitor gyártója; típusa; mérete; ára;
            //illetve amelyik kifejezetten játékra való, ott még megadják azt is, hogy gamer.
            //A méret colban van, az ár nettó és forintban értjük.
            //Forrásfájl tartalma (a tartalmat használd így, ahogy van, az első sort majd nem kell figyelembe venni beolvasáskor):
            //Keszleten levo monitorok
            //Samsung;S24D330H;24;33000  
            //Acer;V227Qbi;21.5;31000  
            //AOC;24G2U;23.8;66000  
            //Samsung;Odyssey G9 C49g95TSSU;49;449989;gamer
            //LG;25UM58-P;25;56000  
            //Samsung;C27JG50QQU;27.5;91000  

            //Feladatok:
            //Lehetőleg minden kiírást a főprogram végezzen el. Próbálj minél több kódot újrahasznosítani. Minden feladatot meg kell oldani hagyományosan, és azután, ha tudod, LINQ-val is.
            //1. Hozz létre egy osztályt a monitorok adatai számára. Olvasd be a fájl tartalmát.
            var monitorok = new List<Monitor>();


            foreach (var i in File.ReadAllLines(@"..\..\..\src\monitorok.txt").Skip(1))
            {


                monitorok.Add(new Monitor(i));
            }


            //2. Írd ki a monitorok összes adatát virtuális metódussal, soronként egy monitort a képernyőre. A kiírás így nézzen ki:
            //Gyártó: Samsung; Típus: S24D330H; Méret: 24 col; Nettó ár: 33000 Ft
            Console.WriteLine("2. feladat");
            for (int i = 0; i < monitorok.Count; i++)
            {
                monitorok[i].kiir();
            }




            //2. Tárold az osztálypéldányokban a bruttó árat is (ÁFA: 27%, konkrétan a 27-tel számolj, ne 0,27-tel vagy más megoldással.)
            Console.WriteLine("Második 2. feladat");






            //3. Tételezzük fel, hogy mindegyik monitorból 15 db van készleten, ez a nyitókészlet. Mekkora a nyitó raktárkészlet bruttó (tehát áfával növelt) értéke?
            //Írj egy metódust, ami meghívásakor kiszámolja a raktárkészlet aktuális bruttó értékét. A főprogram írja ki az értéket.
            Console.WriteLine("3. feladat");


            Console.WriteLine(nyitoKeszlet(monitorok));


            //4. Írd ki egy új fájlba, és a képernyőre az 50.000 Ft feletti nettó értékű monitorok összes adatát (a darabszámmal együtt) úgy,
            //hogy a szöveges adatok nagybetűsek legyenek, illetve az árak ezer forintba legyenek átszámítva.
            //Az ezer forintba átszámítást egy külön függvényben valósítsd meg.
            Console.WriteLine("4. feladat");


            using StreamWriter sw = new StreamWriter(@"..\..\..\src\50kFeletti.txt");
            foreach (var i in monitorok)
            {
                if (i.Ara > 50000)
                {
                    sw.WriteLine($"Gyártó: {i.Gyarto.ToUpper()} Típus: {i.Tipus.ToUpper()}, Méret: {i.Meret}, Ára: {i.Ara / 1000}e FT");
                    Console.WriteLine($"Gyártó: {i.Gyarto.ToUpper()} Típus: {i.Tipus.ToUpper()}, Méret: {i.Meret}, Ára: {i.Ara / 1000}e FT");
                }
            }


            //5. Egy vevő keresi a HP EliteDisplay E242 monitort. Írd ki neki a képernyőre, hogy hány darab ilyen van a készleten.
            //Ha nincs a készleten, ajánlj neki egy olyan monitort, aminek az ára az átlaghoz fölülről közelít. Ehhez használd az átlagszámító függvényt (később lesz feladat).
            Console.WriteLine("5. feladat");
            var keresett = "HP EliteDisplay E242";


            var f5 = monitorok.Find(k => k.Gyarto == keresett);
            var arAtlag = monitorok.Average(av => av.Ara);
            var ajanlott = monitorok.Where(a => a.Ara > arAtlag);


            if (f5 != null)
            {
                Console.WriteLine($"A HP EliteDisplay E242 monitorból {monitorok.Count()}db van");
            }
            else
            {
                Console.WriteLine($"Sajnálom de nincs olyan monitorunk, viszont ezeket tudom ajánlani:");
                foreach (var i in monitorok)
                {
                    Console.WriteLine($"Gyártó: {i.Gyarto}, Ára: {i.Ara}FT");
                }


            }


            //6. Egy újabb vevőt csak az ár érdekli. Írd ki neki a legolcsóbb monitor méretét, és árát.
            Console.WriteLine("6. feladat");


            Console.WriteLine($"A legolcsóbb monitor mérete: {legolcsobbMonitor(monitorok).Meret} és ára: {legolcsobbMonitor(monitorok).Ara}FT");


            //7. A cég akciót hirdet. A 70.000 Ft fölötti árú Samsung monitorok bruttó árából 5%-ot elenged.
            //Írd ki, hogy mennyit veszítene a cég az akcióval, ha az összes akciós monitort akciósan eladná.
            Console.WriteLine("7. feladat");


            var akciosMonitorok = monitorok.Where(mo => mo.Gyarto == "Samsung" && mo.Ara > 70000);
            var akcioArkedvezmeny = akciosMonitorok.Sum(mo => mo.BruttoAr * 0.05);
            Console.WriteLine($"Az akcióval a cég {Math.Round(akcioArkedvezmeny)} Ft-ot veszítene.");


            //8. Írd ki a képernyőre minden monitor esetén, hogy az adott monitor nettó ára a nettó átlag ár alatt van-e, vagy fölötte,
            //esetleg pontosan egyenlő az átlag árral. Ezt is a főprogram írja ki.
            Console.WriteLine("8.feladat");


            var osszAtlag = monitorok.Average(a => a.Ara);


            foreach (var i in monitorok)
            {
                if (i.Ara > osszAtlag)
                {
                    Console.WriteLine($"{i.Gyarto}({i.Tipus}) monitor nettó ára a nettó átlag ár felett van.");
                }
                else if (i.Ara < osszAtlag)
                {
                    Console.WriteLine($"{i.Gyarto}({i.Tipus}) monitor nettó ára a nettó átlag ár alatt van.");
                }
                else if (i.Ara == osszAtlag)
                {
                    Console.WriteLine($"{i.Gyarto}({i.Tipus}) monitor nettó ára a nettó átlag ár azonos.");
                }
            }


            //9. Modellezzük, hogy megrohamozták a vevők a boltot. 5 és 15 közötti random számú vásárló 1 vagy 2 random módon kiválasztott monitort vásárol,
            //ezzel csökkentve az eredeti készletet. Írd ki, hogy melyik monitorból mennyi maradt a boltban.
            //Vigyázz, hogy nulla darab alá ne mehessen a készlet. Ha az adott monitor éppen elfogyott, ajánlj neki egy másikat (lásd fent).
            Console.WriteLine("9. feladat");


            var rnd = new Random();
            int vevok = rnd.Next(5, 16);


            for (int i = 0; i < vevok; i++)
            {
                Console.WriteLine($"{i + 1}. vásárló vásárolt:");


                for (int j = 0; j < rnd.Next(1, 3); j++)
                {
                    var eladottMonitorok = monitorok.Where(m => m.KeszletDarabszam > 0).ToList();


                    if (eladottMonitorok.Any())
                    {
                        var vevoMonitor = eladottMonitorok[rnd.Next(eladottMonitorok.Count)];


                        vevoMonitor.KeszletDarabszam--;
                        Console.WriteLine($"\t{vevoMonitor.Gyarto} {vevoMonitor.Tipus}");
                    }
                    else
                    {
                        Console.WriteLine("Nincs elég monitor a készleten.");
                    }
                }
            }


            Console.WriteLine("Készlet utáni állapot:");
            foreach (var monitor in monitorok)
            {
                Console.WriteLine($"\t{monitor.Gyarto} {monitor.Tipus}: {monitor.KeszletDarabszam} db");
            }


            //10. Írd ki a képernyőre, hogy a vásárlások után van-e olyan monitor, amelyikből mindegyik elfogyott (igen/nem).
            Console.WriteLine("10. feladat");


            var maradtMonitorok = monitorok.Where(m => m.KeszletDarabszam > 0).ToList();
            if (maradtMonitorok == null)
            {
                Console.WriteLine("Igen");
            }
            else
            {
                Console.WriteLine("Nem");
            }


            //11. Írd ki a gyártókat abc sorrendben a képernyőre. Oldd meg úgy is, hogy a metódus írja ki, és úgy is, hogy a főprogram.
            Console.WriteLine("11. feladat");
            var gyartokAbcSorrendben = monitorok.Select(mo => mo.Gyarto).Distinct().OrderBy(gyarto => gyarto);
            foreach (var gyarto in gyartokAbcSorrendben)
            {
                Console.WriteLine(gyarto);
            }


            //12. Csökkentsd a legdrágább monitor bruttó árát 10%-kal, írd ki ezt az értéket a képernyőre.
            Console.WriteLine("12. feladat");
            var legdragabbMonitor = monitorok.OrderByDescending(mo => mo.BruttoAr).First();
            legdragabbMonitor.Ara = (int)(legdragabbMonitor.BruttoAr * 0.9);
            Console.WriteLine($"A legdrágább monitor új bruttó ára: {legdragabbMonitor.Ara} Ft");


        }
    }
}
