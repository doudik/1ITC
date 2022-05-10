using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErikaFashionForms
{
    internal class Kosik
    {
        //Kupony
        private List<string> Coupons = new List<string>() {
            "ERIKA-20",
            "ERIKA-10",
            "ERIKA-15"
        };

        public string CheckCoupon(string coupons)
        {
            foreach (var item in Coupons)
            {
                if (item == coupons)
                {
                    return item;
                }
            }
            return "Kupon nebyl nalezen!";
        }
        //TODO Kosik
        static IDictionary<string, IDictionary<string, int>> kosik = new Dictionary<string, IDictionary<string, int>>();
        static IDictionary<string, int> velikostiAKs = new Dictionary<string, int>();
        public static void PridejDoKosiku(string item, string velikost, int ks)
        {
            //if (Sklad.ZkontrolujZasoby(item, velikost, ks) == true) {
            //velikostiAKs.Add(velikost, ks);
            //kosik.Add(item, velikostiAKs);
            IDictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("P", 10);
            kosik.Add("ABCD", dic);
            kosik["ABCD"]["P"] -= 2;
            VypisKosik();
            //}
        }
        static void VypisKosik()
        {
            Console.WriteLine(kosik["ABCD"]["P"]);
        }
        //TODO Zaplat
        private void Zaplat()
        {
            foreach (var item in kosik)
            {

            }
        }

    }
}