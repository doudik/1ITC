using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Písemná_práce
{
    public class Zak
    {
        static List<string> jmena = new List<string>() { "K", "T", "P", "V", "O", "L", "Y", "Q", "W", "E" };
        static List<int> ukol = new List<int>();
        static Random r = new Random();

        public static void ZadejUkol() {
            for (int i = 0; i < ukol.Count; i++)
            {
                ukol.Add(i);
            }

            while (ukol.Count > 0) {
                int ukolRnd = r.Next(0,ukol.Count);
                Console.WriteLine("{0} = {1}", jmena[0], ukol[ukolRnd]);
                jmena.Remove(jmena[0]);
                ukol.Remove(ukol[ukolRnd]);
            }
            foreach (string jmeno in jmena) {
                Console.WriteLine("{0} nemá žádný úkol", jmeno);
            }
        }
    }
}
