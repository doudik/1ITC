using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Kocka : Zvire
    {
        public override void Zvuk2()
        {
            base.Zvuk2();
            Console.WriteLine("Thorova kočka dělá mňau, vole");   
        }
    }
}
