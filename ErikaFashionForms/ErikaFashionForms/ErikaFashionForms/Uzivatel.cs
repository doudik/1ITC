using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErikaFashionForms
{
    internal class Uzivatel
    {
        string jmeno, nick, email, heslo;
        int kredit, vek;

        public Uzivatel(string jmeno, int vek, string nick, string email, string heslo)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            this.nick = nick;
            this.email = email;
            this.heslo = heslo;
            kredit = 0;
        }
        private bool CheckCoupon(string coupon)
        {
            //TODO
            return true;
        }
    }
}
