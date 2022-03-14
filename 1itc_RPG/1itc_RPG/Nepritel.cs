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
        public string priserka;
        public float hp;
        public int dmg;
        public int lvl;
        float xp;
        string[] priserky = {"Kostlivec", "Bojovník", "Mág", "Zombík", "Creeper", "Pavouk"};
        public Nepritel(Hrac h) {
            priserka = priserky[rnd.Next(0, priserky.Length)];
            hp = h.hp * rnd.Next(1, 3);
            lvl = h.lvl*rnd.Next(0,4);
            dmg = rnd.Next(0, 20) * lvl;
            xp = hp + lvl + dmg;
        }
    }
}
