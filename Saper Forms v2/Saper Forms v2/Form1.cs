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
    public partial class Form1 : Form
    {
        Gra g;
        Logika l = new Logika();
        Panel panel1;
        public static Timer zegar;
        int zegarUtworzony = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = new Gra();
            Controls.Remove(panel1);
            tworzenie_Panelu();
            if(zegarUtworzony == 0) tworzenie_Zegara();
            this.Size = new Size((Dane.pX * 20) + 50, (Dane.pY * 20) + 140);
            l.zmianaBomb += new EventHandler(zmiana_Bomb);
            g.start(panel1);
        }

        private void tworzenie_Panelu()
        {
            panel1 = new Panel();
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(Dane.pX*20, Dane.pY*20 + 20);
            this.panel1.TabIndex = 0;
            this.Controls.Add(this.panel1);
        }

        private void tworzenie_Zegara()
        {
            zegar = new Timer();
            zegar.Interval = 1000;
            zegar.Tick += zmiana_Czasu;
            zegarUtworzony = 1;
        }

        private void zmiana_Czasu(object sender, EventArgs e)
        {
            Dane.czas++;
            label1.Text = Dane.czas.ToString();
        }

        private void zmiana_Bomb(object sender, EventArgs e)
        {
            label2.Text = Dane.pozostałoBomb.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nowaGraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void opcjeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void zakończToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
