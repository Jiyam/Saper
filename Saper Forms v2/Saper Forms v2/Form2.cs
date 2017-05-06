using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper_Forms_v2
{
    public partial class Form2 : Form
    {
        Dane d = new Dane();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool w1,w2,w3;
            int res1, res2, res3;
            w1 = int.TryParse(textBox1.Text, out res1);
            if((w1 == true) && (res1 > 0) && (res1 < (Dane.pX * Dane.pY - 1))) Dane.ilość_Bomb = res1;

            w2 = int.TryParse(textBox2.Text, out res2);
            if ((w2 == true) && (res2 > 10) && (res2 <= 65)) Dane.pX = res2;

            w3 = int.TryParse(textBox3.Text, out res3);
            if ((w3 == true) && (res3 > 10) && (res3 <= 30)) Dane.pY = res3;
        }
    }
}
