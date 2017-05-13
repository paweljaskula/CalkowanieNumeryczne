using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCalkowanieNumeryczne
{
    class Funkcje
    {
        public static double wielomian(int[] tab, double x)
        {
            double rezultat = tab[tab.Length - 1];
            double potega = 1;
            for (int i = tab.Length - 2; i >= 0; i--)
            {
                potega *= x;
                rezultat += tab[i] * potega;
            }
            return rezultat;
        }
    }
}
