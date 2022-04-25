using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smazat
{
    internal class Ucet
    {
        static int celkovyPocetUctu;
        public int zustatek { get; set; }
        public Ucet() {
            celkovyPocetUctu++;
        }
    }
}
