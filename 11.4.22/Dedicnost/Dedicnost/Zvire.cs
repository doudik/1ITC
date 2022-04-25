namespace Dedicnost
{
    class A
    {


        static void Main(string[] args)
        {
            B b = new B();
            b.NejakaMetoda();
        }
        public int hodnota = 10;
        public void Secti() {
            Console.WriteLine("sečetl jsem nějakou hodnotu:)");
        }
        public void Odecti() {
            Console.WriteLine("Odečetl jsem nějakou hodnotu :(");
        }
    }
}