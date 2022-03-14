using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1itc_RPG
{
    internal class Nepritel
    {
        Random rnd = new Random();
        float hp;
        int dmg;
        int lvl;
        float xp;

        public Nepritel(Hrac h) {
            hp = h.hp*rnd.Next()*1.5f;
            lvl = h.lvl*rnd.Next()*4;
            dmg = rnd.Next(0, 20) * lvl;
            xp = hp + lvl + dmg;
        }
    }
}
