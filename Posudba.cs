using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaBiblioteka
{
    internal class Posudba
    {

        DateTime datum_p, datum_v;
        int ID_Knjige, ID_Korisnik;

        public Posudba(DateTime datum_p, DateTime datum_v, int iD_Knjige, int iD_Korisnik)
        {
            this.datum_p = datum_p;
            this.datum_v = datum_v;
            ID_Knjige = iD_Knjige;
            ID_Korisnik = iD_Korisnik;
        }

        public DateTime Datum_p { get => datum_p; set => datum_p = value; }
        public DateTime Datum_v { get => datum_v; set => datum_v = value; }
        public int ID_Knjige1 { get => ID_Knjige; set => ID_Knjige = value; }
        public int ID_Korisnik1 { get => ID_Korisnik; set => ID_Korisnik = value; }
    }
}
