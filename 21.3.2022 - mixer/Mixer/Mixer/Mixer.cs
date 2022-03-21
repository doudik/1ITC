using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer
{
    internal class Mixer
    {
        public int rpm {get; set;}
        public int Rpm {
            get {return rpm; }
            private set { rpm = value; }
        }
        public bool isOn;
        public int vykon;
        public int objem;

        public Mixer(int rpm, int vykon, int objem) {
            this.rpm = rpm;
            this.vykon = vykon;
            this.objem = objem;
            isOn = false;
        }

        public void ZmenRpm(int arg) {
            this.rpm = arg;
        }
        public void SetRpm(int val) {
            Console.WriteLine("Hele někdo ti změnil hodnotu");
            this.rpm = val;
        }
        public int GetRpm() {
            return this.rpm;
        }
    }
}
