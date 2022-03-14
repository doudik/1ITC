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
                "Mana: {5}",
                h.hp, h.dmg, h.lvl, h.experience, h.expToNextLvl, h.mana);
        }
        void VytvorNepritele(Hrac h) {
            Nepritel kostlivec = new Nepritel(h);
        }
    }
}
