using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper_Forms_v2
{
    class Dane
    {
        public static int pX = 15;
        public static int pY = 15;
        public static int ilość_Bomb = 10;
        public static int[,] liczby;
        public static bool[,] zakryte;
        public static Button[,] przyciski;
        public bool[,] bomby;
        public static int[,] flagi;
        public static int czas = 0;
        public static int pozostałoBomb;
    }
}
