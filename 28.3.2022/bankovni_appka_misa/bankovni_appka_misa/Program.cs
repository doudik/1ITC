using System;

namespace bankovní_účet1
{
    class Program
    {
        //heslo k učtu 1 je 12345 a k druhýmu 69420
        static int b = 0;
        static int ucet1 = 1000;
        static int ucet2 = 1000;
        static void Main(string[] args)
        {
            vybeructu();
        }
        static void nabídka1()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("uživatel " + b);
            Console.WriteLine("------------------------");
            Console.WriteLine("vyber z nabídky:");
            Console.WriteLine("1: Vložit na účet");
            Console.WriteLine("2: Vybrat z účtu");
            Console.WriteLine("3: Zobrazit zůstatek");
            Console.WriteLine("4: zpět na výběr účtu");
            int c = Int32.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Kolik chcete vložit?");
                int g = Int32.Parse(Console.ReadLine());
                ucet1 += g;
                Console.WriteLine("vložil jste: " + g);
                g = 0;
                chcetezpet();
            }
            else if (c == 2)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Kolik chcete vybrat?");

                int h = Int32.Parse(Console.ReadLine());
                if (h <= ucet1 && h > 0)
                {
                    ucet1 -= h;
                    Console.WriteLine("vybral jste: " + h);
                    h = 0;
                    chcetezpet();
                }
                else
                {
                    Console.WriteLine("zadaná částka je větší než zůstatek");
                    chcetezpet();
                }

            }
            else if (c == 3)
            {
                Console.WriteLine("Zůstatek je : " + ucet1);
                chcetezpet();
            }
            else if (c == 4)
            {
                vybeructu();
            }
        }
        static void nabídka2()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("uživatel " + b);
            Console.WriteLine("------------------------");
            Console.WriteLine("vyber z nabídky:");
            Console.WriteLine("1: Vložit na účet");
            Console.WriteLine("2: Vybrat z účtu");
            Console.WriteLine("3: Zobrazit zůstatek");
            Console.WriteLine("4: zpět na výběr účtu");
            int c = Int32.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Kolik chcete vložit?");
                int g = Int32.Parse(Console.ReadLine());
                ucet2 += g;
                Console.WriteLine("vložil jste: " + g);
                g = 0;
                chcetezpet2();
            }
            else if (c == 2)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Kolik chcete vybrat?");

                int h = Int32.Parse(Console.ReadLine());
                if (h <= ucet2 && h > 0)
                {
                    ucet2 -= h;
                    Console.WriteLine("vybral jste: " + h);
                    h = 0;
                    chcetezpet2();
                }
                else
                {
                    Console.WriteLine("zadaná částka je větší než zůstatek");
                    chcetezpet2();
                }

            }
            else if (c == 3)
            {
                Console.WriteLine("Zůstatek je : " + ucet2);
                chcetezpet2();

            }
            else if (c == 4)
            {
                vybeructu();
            }



        }
        static void vybeructu()
        {
            Console.WriteLine("Vítejte v bance Kobra11");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Vyberte si účet :");
            Console.WriteLine("1");
            Console.WriteLine("2");
            b = Int32.Parse(Console.ReadLine());
            if (b == 1)
            {

                zadejheslo();

            }
            else if (b == 2)
            {
                zadejheslo2();
            }
            else
            {
                Console.WriteLine("neznámý účet");
            }
        }
        static void chcetezpet()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("chcete zpět do nabídky?");
            Console.WriteLine("1: ano");
            Console.WriteLine("2: ne");
            int l = Int32.Parse(Console.ReadLine());
            if (l == 1)
            {
                nabídka1();
            }
            if (l == 2)
            {
                Console.WriteLine("nashledanou");
            }
        }
        static void chcetezpet2()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("chcete zpět do nabídky?");
            Console.WriteLine("1: ano");
            Console.WriteLine("2: ne");
            int l = Int32.Parse(Console.ReadLine());
            if (l == 1)
            {
                nabídka2();
            }
            if (l == 2)
            {
                Console.WriteLine("nashledanou");
            }
        }
        static void zadejheslo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Zadej heslo");
            int lol = Int32.Parse(Console.ReadLine());
            if (lol == 12345)
            {
                nabídka1();
            }
            else
            {
                Console.WriteLine("heslo není správné");
            }
        }
        static void zadejheslo2()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Zadej heslo");
            int lol = Int32.Parse(Console.ReadLine());
            if (lol == 69420)
            {
                nabídka2();
            }
            else
            {
                Console.WriteLine("heslo není správné");

            }
        }
    }
}




