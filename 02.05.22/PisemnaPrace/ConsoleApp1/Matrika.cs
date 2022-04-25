using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Matrika
    {
        string jmeno, prijmeni, rodneCislo, datumNarozeni;
        static List<Matrika> lidi = new List<Matrika>();

        public Matrika(string jmeno, string prijmeni, string rodneCislo, string datumNarozeni) {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.rodneCislo = rodneCislo;
            this.datumNarozeni = datumNarozeni;
            lidi.Add(this);
        }
        public static void Svatba(Matrika a, Matrika b, string prijmeni)
        {
            a.prijmeni = prijmeni;
            b.prijmeni = prijmeni;
        }
        public static void Vypis() { 
            foreach(var item in lidi)
            {
                Console.WriteLine("{0} {1}", item.jmeno, item.prijmeni);
            }
        }
        
    }
}
