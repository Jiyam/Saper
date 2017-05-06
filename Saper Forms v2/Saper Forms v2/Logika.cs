using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Saper_Forms_v2
{
    class Logika
    {
        Dane d = new Dane();
        public event EventHandler zmianaBomb;
        public void zmianaBombWłącz()
        {
            if (zmianaBomb != null)
            {
                zmianaBomb(this, new EventArgs());
            }
        }
        public Button[,] Tworzenie_Przycisku(Panel panel, int[,] Liczby, Button[,] przyciski)
        {
            int id = 0;
            int px = 0;
            int py = 0;
            for (int y = 0; y < Dane.pY; y++)
            {
                py += 20;
                px = 0;
                for (int x = 0; x < Dane.pX; x++)
                {
                    przyciski[x, y] = new Button();
                    przyciski[x, y].Text = "";
                    przyciski[x, y].Width = 20;
                    przyciski[x, y].Height = 20;
                    przyciski[x, y].Text = Liczby[x, y].ToString();
                    przyciski[x, y].Font = new System.Drawing.Font("Arial Black", 8F);
                    Point Pozycja_Przycisku = new Point(px, py);
                    przyciski[x, y].Location = Pozycja_Przycisku;
                    panel.Controls.Add(przyciski[x, y]);
                    przyciski[x, y].MouseDown += new MouseEventHandler(Kliknięcie);
                    przyciski[x, y].Name = id.ToString();
                    id++;
                    px += 20;
                }
            }
            return przyciski;
        }
        private void Kliknięcie(object sender, MouseEventArgs e)
        {
            int i = 0;
            Button btn = sender as Button;
            for (int y = 0; y < Dane.pY; y++)
            {
                for (int x = 0; x < Dane.pX; x++)
                {
                    if (i == int.Parse(btn.Name))
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            if (Dane.flagi[x, y] == 0)
                                Dane.zakryte = odkrycie(Dane.zakryte, Dane.liczby, x, y);
                            czyWygrana(Dane.liczby, Dane.zakryte);
                        }
                        else if (e.Button == MouseButtons.Right)
                            Dane.flagi = flaga(Dane.flagi, x, y, Dane.zakryte);
                    }
                    i++;
                }
            }
            Znaki(Dane.liczby, Dane.zakryte, Dane.przyciski);
        }
        public bool[,] Czyszczenie_Bomb(bool[,] Bomby)
        {
            for (int y = 0; y < Dane.pY; y++)
            {
                for (int x = 0; x < Dane.pX; x++)
                {
                    Bomby[x, y] = false;
                }
            }
            return Bomby;
        }
        public bool[,] Tworzenie_Bomb(bool[,] Bomby)
        {
            int x, y;
            Random r = new Random();
            for (int i = 0; i < Dane.ilość_Bomb; i++)
            {
                do
                {
                    x = r.Next(Dane.pX);
                    y = r.Next(Dane.pY);
                }
                while (Bomby[x, y] != false);
                Bomby[x, y] = true;
            }
            return Bomby;
        }
        public int[,] Liczby(ref int[,] liczby, bool[,] Bomby)
        {
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    if (Bomby[i, j] == true) liczby[i, j] = -1;
                    else
                    {
                        liczby[i, j] = 0;
                        for (int x = i - 1; x <= i + 1; x++)
                        {
                            for (int y = j - 1; y <= j + 1; y++)
                            {
                                if ((x >= 0) && (y >= 0) && (x < Dane.pX) && (y < Dane.pY))
                                    if (Bomby[x, y] == true) liczby[i, j]++;
                            }
                        }
                    }
                }
            }
            return liczby;
        }
        public bool[,] Ukrycie(ref bool[,] zakryte)
        {
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    zakryte[i, j] = true;
                }
            }
            return zakryte;
        }
        public bool[,] odkrycie(bool[,] zakryte, int[,] liczby, int x, int y)
        {
            zakryte[x, y] = false;
            if (liczby[x, y] == 0)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if ((i >= 0) && (j >= 0) && (i < Dane.pX) && (j < Dane.pY) && (zakryte[i, j] == true))
                        {
                            zakryte = odkrycie(zakryte, liczby, i, j);
                        }
                    }
                }
            }
            else if (liczby[x, y] == -1) Koniec();
            return zakryte;
        }
        public int[,] czyszczFlagi(int[,] flagi)
        {
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    flagi[i, j] = 0;
                }
            }
            return flagi;
        }
        public int[,] flaga(int[,] flagi, int x, int y, bool[,] zakryte)
        {
            if (flagi[x, y] == 0)
            {
                Dane.pozostałoBomb--;
                zmianaBombWłącz();
                flagi[x, y] = 1;
            }
            else if (flagi[x, y] == 1)
            {
                Dane.pozostałoBomb++;
                zmianaBombWłącz();
                flagi[x, y] = 2;
            }
            else flagi[x, y] = 0;
            return flagi;
        }
        public void Koniec()
        {
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    if(Dane.liczby[i, j] == -1) Dane.zakryte[i, j] = false;
                    Dane.przyciski[i, j].Enabled = false;
                }
            }
            Znaki(Dane.liczby, Dane.zakryte, Dane.przyciski);
            //f.zegar.Enabled = false;
            MessageBox.Show("Przegrana...");
        }
        public int czyWygrana(int[,] liczby, bool[,] zakryte)
        {
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    if ((zakryte[i, j] == true) && (liczby[i, j] > -1)) return 0;
                }
            }
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    Dane.przyciski[i, j].Enabled = false;
                }
            }
            //f.zegar.Enabled = false;
            MessageBox.Show("Wygrana!!!");
            return 0;
        }
        public void Znaki(int[,] liczby, bool[,] zakryte, Button[,] przyciski)
        {
            for (int j = 0; j < Dane.pY; j++)
            {
                for (int i = 0; i < Dane.pX; i++)
                {
                    przyciski[i, j].Image = null;
                    if (zakryte[i, j] == false)
                    {
                        przyciski[i, j].BackColor = Color.LightGray;
                        if (liczby[i, j] == -1)
                        {
                            przyciski[i, j].BackColor = Color.Red;
                            przyciski[i, j].Image = Properties.Resources.Bomba2;
                            przyciski[i, j].Text = "";
                        }
                        else if (liczby[i, j] == 0) przyciski[i, j].Text = "";
                        else
                        {
                            switch(liczby[i, j])
                            {
                                case 1:
                                    przyciski[i, j].ForeColor = Color.Blue;
                                    break;
                                case 2:
                                    przyciski[i, j].ForeColor = Color.Green;
                                    break;
                                case 3:
                                    przyciski[i, j].ForeColor = Color.Red;
                                    break;
                                case 4:
                                    przyciski[i, j].ForeColor = Color.DarkBlue;
                                    break;
                                case 5:
                                    przyciski[i, j].ForeColor = Color.DarkRed;
                                    break;
                                case 6:
                                    przyciski[i, j].ForeColor = Color.LightBlue;
                                    break;
                                case 7:
                                    przyciski[i, j].ForeColor = Color.Orange;
                                    break;
                                case 8:
                                    przyciski[i, j].ForeColor = Color.Ivory;
                                    break;
                            }
                            przyciski[i, j].Text = liczby[i, j].ToString();
                        }
                    }
                    else
                    {
                        if (Dane.flagi[i, j] == 1)
                        {
                            przyciski[i, j].Image = Properties.Resources.Flaga;
                            //przyciski[i, j].Text = "F";
                        }
                        else if (Dane.flagi[i, j] == 2) przyciski[i, j].Text = "?";
                        else przyciski[i, j].Text = "";
                        przyciski[i, j].BackColor = Color.White;
                    }
                }
            }
        }
    }
}
