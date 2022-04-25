namespace Interface {
    class Program
    {
        static void Main(string[] args)
        {
            Pes pes = new Pes();
            Kocka kocka = new Kocka();
            pes.Zvuk();
            kocka.Zvuk2();
        }

    }

}