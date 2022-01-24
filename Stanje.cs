using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaBiblioteka
{
    internal class Stanje
    {
        int ID_Knjige, Kolicina;

        public Stanje(int iD_Knjige, int kolicina)
        {
            ID_Knjige = iD_Knjige;
            Kolicina = kolicina;
        }

        public int ID_Knjige1 { get => ID_Knjige; set => ID_Knjige = value; }
        public int Kolicina1 { get => Kolicina; set => Kolicina = value; }
    }
}
