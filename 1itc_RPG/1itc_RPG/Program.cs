namespace _1itc_RPG;

class Program {
    static void Main(string[] args)
    {
        Hrac h = new Hrac("Bajaja");
        Rozhovor r = new Rozhovor();
        r.Dialog(h);
    }
}