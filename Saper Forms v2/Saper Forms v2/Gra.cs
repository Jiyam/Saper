using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper_Forms_v2
{
    public partial class Gra
    {
        Logika l = new Logika();
        Dane d = new Dane();
        public void start(Panel panel1)
        {
            Dane.czas = -1;
            Dane.pozostałoBomb = Dane.ilość_Bomb;
            Dane.liczby = new int[Dane.pX, Dane.pY];
            Dane.zakryte = new bool[Dane.pX, Dane.pY];
            Dane.przyciski = new Button[Dane.pX, Dane.pY];
            d.bomby = new bool[Dane.pX, Dane.pY];
            Dane.flagi = new int[Dane.pX, Dane.pY];
            Dane.przyciski = l.Tworzenie_Przycisku(panel1, Dane.liczby, Dane.przyciski);
            d.bomby = l.Czyszczenie_Bomb(d.bomby);
            d.bomby = l.Tworzenie_Bomb(d.bomby);
            Dane.liczby = l.Liczby(ref Dane.liczby, d.bomby);
            Dane.flagi = l.czyszczFlagi(Dane.flagi);
            Dane.zakryte = l.Ukrycie(ref Dane.zakryte);
            l.Znaki(Dane.liczby, Dane.zakryte, Dane.przyciski);
            Form1.zegar.Enabled = true;
            l.zmianaBombWłącz();
        }
    }
}
