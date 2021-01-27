using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskinHarjoitus101
{
    public class Laskin
    {
        public int Erotus(int luku1, int luku2)
        {
            return luku1 - luku2;
        }
        
        // Metodi laskee summan kahdelle luvulle.
        public int Summa(int luku1, int luku2)
        {
            return luku1 + luku2;
        }
        
        // Metodi laskee jakojäännöksen kahdelle luvulle.
        //
        public int Jakojaannos(int luku1, int luku2)
        {
            return luku1 / luku2;
        }
    }
}
