using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskinHarjoitus101
{
    public class Laskin
    {
        /// <summary>
        /// Metodi laskee erotuksen kahdelle luvulle.
        /// </summary>
        /// <param name="luku1"></param>
        /// <param name="luku2"></param>
        /// <returns></returns>
        public int Erotus(int luku1, int luku2)
        {
            return luku1 - luku2;
        }

        /// <summary>
        /// Metodi laskee tulon kahdelle luvulle.
        /// </summary>
        /// <param name="luku1"></param>
        /// <param name="luku2"></param>
        /// <returns></returns>
        public int Tulo(int luku1, int luku2)
        {
            return luku1 * luku2;
        }
    }
}
