namespace Mixer;

class Program {
    static void Main(string[] args) { 
        Mixer tesla3000 = new Mixer(200, 200, 1500);
        tesla3000.ZmenRpm(2000000);
        Mixer jarda = new Mixer(200, 200, 1500);
        Zaskodnik z = new Zaskodnik();
        z.ZmenRpm(tesla3000, 0);
        Console.WriteLine("Tvůj mixér se točí: " + tesla3000.Rpm);
    }

}