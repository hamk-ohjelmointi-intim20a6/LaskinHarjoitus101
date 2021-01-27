using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskinHarjoitus101
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Lasketaan kahden luvun summa");
            int summa = 5 + 3;
            Console.WriteLine(summa);

            Console.WriteLine("Lasketaan kahden luvun erotus");
            var laskin = new Laskin();
            int erotus = laskin.Erotus(6, 8);
            Console.WriteLine(erotus);

            Console.WriteLine("Lasketaan kahden luvun erotus");
            int tulo = laskin.Tulo(5, 7);
            Console.WriteLine(tulo);

            Console.ReadLine();
        }
    }
}
