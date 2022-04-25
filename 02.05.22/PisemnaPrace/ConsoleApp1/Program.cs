namespace ConsoleApp1{
    class Programo {

        static Matrika uz = new Matrika("Pavel", "Novak", "123456/4444", "22.1.1996");
        static Matrika uz2 = new Matrika("Jana", "Lopata", "123456/4444", "22.1.1996");
        static void Main(string[] args) {
            while (true) {
                Dialog();
            }
        }
        static void Dialog() {
            Console.WriteLine("1. Změna příjmení");
            Console.WriteLine("2. Vypiš jména");
            switch (Console.ReadLine()) {
                case "1":
                    Console.WriteLine("Zadejte příjmení:");
                    string prijmeni = Console.ReadLine();
                    Matrika.Svatba(uz, uz2, prijmeni);
                    break;
                case "2":
                    Matrika.Vypis();
                    break;
                default:
                    Console.WriteLine("Máš tam chybu!");
                    break;
            }
        }
    }
}