using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErikaFashionForms
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Uzivatel Fanda = new Uzivatel("Fanda", 15, "fan", "fanda.novak@seznam.cz", "fandajebuh123");
            Kosik.PridejDoKosiku("adawd", "asdawdqdq", 10);
        
        }
    }
}
