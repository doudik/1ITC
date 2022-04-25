using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uvod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.Black;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PohybKostkou();
        }

        private void PohybKostkou()
        {
            int x = panel1.Location.X;
            int y = panel1.Location.Y;
            if ((x + panel1.Width) >= this.Width)
            {
                panel1.Location = new Point(0, y);
            }
            else {
                panel1.Location = new Point(x + 10, y);
            }
        }
    }
}
