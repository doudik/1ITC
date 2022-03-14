namespace _1itc_RPG;

class Program {
    static void Main(string[] args)
    {
        Hrac p1 = new Hrac("Bajaja");
        Rozhovor r = new Rozhovor();
        r.Dialog(p1);
    }
}