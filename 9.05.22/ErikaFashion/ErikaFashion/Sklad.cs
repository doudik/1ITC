using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErikaFashion
{
    internal class Sklad
    {
        //TODO dodělat sklad
        static IDictionary<string, IDictionary<string, int>> zasoby = new Dictionary<string, IDictionary<string,int>>();
        internal static bool ZkontrolujZasoby(string item, string velikost, int ks)
        {
            if(zasoby[item] > 1)
        }
    }
}
