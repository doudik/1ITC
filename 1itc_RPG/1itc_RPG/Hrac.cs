using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1itc_RPG
{
    internal class Hrac
    {
        public string nickname;
        public float hp;
        public int dmg;
        public int lvl;
        public float experience;
        public float expToNextLvl;
        public int mana;

        public Hrac(string nickname)
        {
            this.nickname = nickname;
            hp = 100f;
            dmg = 20;
            lvl = 1;
            experience = 0;
            expToNextLvl = 50;
            mana = 50;
        }
    }
}
