namespace NovaLatka {
    class Program
    {
        static void Main(string[] args)
        {
            Penezenka ucet = new Penezenka("EUR");
            Penezenka ucet2 = new Penezenka("EUR");
            ucet.Zustatek = -1000;
            ucet.ZmenaMeny("012391293123");
            Console.WriteLine(ucet.SlevovyKupon);
            Console.WriteLine(Penezenka.pocetKaret);
        }
    }
}
