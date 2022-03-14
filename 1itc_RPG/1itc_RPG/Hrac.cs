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
        public float maxHP;
        public float hp;
        public int dmg;
        public int lvl;
        public float experience;
        public float expToNextLvl;
        public int mana;
        Random r = new Random();

        public Hrac(string nickname)
        {
            this.nickname = nickname;
            hp = 100f;
            maxHP = hp;
            dmg = 20;
            lvl = 1;
            experience = 0;
            expToNextLvl = 50;
            mana = 50;
        }
        public void UpdateStats(Hrac h) {
            hp = h.hp / 3 + (lvl * 50);
            maxHP = 100 + (lvl * 50);
            dmg = 20 + (lvl * r.Next(20, 100));
            lvl++;
            experience = 0;
            expToNextLvl = lvl * 50;
            mana += 20;
        }
    }
}
