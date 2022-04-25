using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IZvire
    {
        public abstract void Zvuk();
        public virtual void Zvuk2() {
            Console.WriteLine("Dělám random zvuk, haha");
        }
    }
}
