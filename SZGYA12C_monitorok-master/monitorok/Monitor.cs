using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace monitorok
{
    class Monitor
    {
        public string Gyarto { get; set; }
        public string Tipus { get; set; }
        public double Meret { get; set; }
        public int Ara { get; set; }
        public bool Gamer { get; set; }

        public int KeszletDarabszam { get; set; } = 15;

        public double BruttoAr => Ara * 0.27;


        public void kiir()
        {
            Console.WriteLine($"Gyártó: {Gyarto,7}; Típus: {Tipus,10}; Méret: {Meret,5} col; Nettó ár {Ara,5}Ft");
        }

        public Monitor(string sor)
        {
            var atmeneti = sor.Split(';');
            Gyarto = atmeneti[0];
            Tipus = atmeneti[1];
            Meret = Convert.ToDouble(atmeneti[2]);
            Ara = Convert.ToInt32(atmeneti[3]);
            Gamer = atmeneti.Length > 4 && atmeneti[4] == "gamer";
        }
    }
}
