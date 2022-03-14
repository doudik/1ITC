using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1itc_RPG
{
    class Rozhovor
    {
        public void Dialog(Hrac h)
        {
            Console.WriteLine("\t----- Vítej, {0}! -----", h.nickname);
            Console.WriteLine("> Vítám tě ve světe Arizona.\n");
            VypisStatyHrace(h);

        }
        void VypisStatyHrace(Hrac h)
        {
            Console.WriteLine("Tvoje HP: {0} \n" +
                "DMG: {1} \n LvL: {2} \n XP: {3} \n XP do dalšího lvl: {4}\n " +
                "Mana: {5}\n\n",
                h.hp, h.dmg, h.lvl, h.experience, h.expToNextLvl, h.mana);
            VytvorNepritele(h);
        }
        void VytvorNepritele(Hrac h) {
            Nepritel n1 = new Nepritel(h);
            Console.WriteLine("-------------------------------\n" +
                "Potkal si: {0}\n" +
                "HP: {1}\n"
                + "DMG: {2}\n" +
                "LvL: {3}",n1.priserka, n1.hp, n1.dmg, n1.lvl);
        }
    }
}
