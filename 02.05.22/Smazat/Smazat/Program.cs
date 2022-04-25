namespace Smazat {
    class Program
    {
        static void Main(string[] args) {
            Ucet ucet1 = new Ucet();
            List<Ucet> list= new List<Ucet>();
            list.Add(ucet1);

            foreach (var item in list) {
                Console.WriteLine(item.zustatek);
            }

            int VypisZustatek(Ucet u) {
                return u.zustatek;
            }
            void ZmenZustatek(Ucet u, int hodnota) {
                u.zustatek = hodnota;
            }
        }
    }
}


