using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace NovaLatka
{
 
    class Penezenka
    {
        static HttpClient klient = new HttpClient();

        int zustatek;
        public int Zustatek { 
            get { return zustatek; }
            set {
                if (value > 0) {
                    zustatek += value;
                }
            }
        }
        public static int pocetKaret = 0;
        string mena;
        string slevovyKupon;
        public string SlevovyKupon {
            get { return VygenerujSlevovyKupon(); }
        }

        private string VygenerujSlevovyKupon()
        {
            Random rnd = new Random();
            string abeceda = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            for (int i = 1; i < 25; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    slevovyKupon += "-";
                }
                else {
                    slevovyKupon += abeceda[rnd.Next(abeceda.Length)];
                }
            }
            return slevovyKupon;
        }

        public Penezenka(string mena) {
            zustatek = 0;
            this.mena = mena;
            pocetKaret++;
        }
        public void ZmenaMeny(string mena) {
            if (mena == "EUR" || mena == "CZK")
            {
                if (this.mena == "EUR")
                {
                    Zustatek /= 25;
                }
                else {
                    Zustatek *= 25;
                }
                this.mena = mena;
                

            }
            else {
                Console.WriteLine("Tuhle měnu nepodporujeme!");
            }
        }
    }
}
