using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppKajak
{
    class Kenu
    {
        public string Nev { get; set; }
        public int HajoAzonosito { get; set; }
        public string HajoTipus { get; set; }
        public int SzemelyekSzama { get; set; }
        public int ElvitelOra { get; set; }
        public int ElvitelPerc { get; set; }
        public int VisszaOra { get; set; }
        public int VisszaPerc { get; set; }

        public Kenu(string sor)
        {
            var valami = sor.Split(';');
            Nev = valami[0];
            HajoAzonosito = int.Parse(valami[1]);
            HajoTipus = valami[2];
            SzemelyekSzama = int.Parse(valami[3]);
            ElvitelOra = int.Parse(valami[4]);
            ElvitelPerc = int.Parse(valami[5]);
            VisszaOra = int.Parse(valami[6]);
            VisszaPerc = int.Parse(valami[7]);
        }

        //2. feladat
        public bool LetezikMar(List<Kenu> kolcsonzesek)
        {
            return kolcsonzesek.Any(k => k.HajoAzonosito == this.HajoAzonosito &&
                                          k.HajoTipus == this.HajoTipus &&
                                          k.SzemelyekSzama == this.SzemelyekSzama);
        }

    }

}
