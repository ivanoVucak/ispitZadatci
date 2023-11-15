using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraPravokutnogTrokuta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hipotenuza = 0;
            int kateta1 = 0;
            int kateta2 = 0;
            int rez = 0;


            Console.WriteLine("Ovo je provjera pravokutnog trokuta");

                Console.Write("Unesite tri vrijednosti odvojene razmakom --> ");

            var znak = Console.ReadLine();
            var podatak = znak.Split(' ');
            var x = int.Parse(podatak[0]);
            var y = int.Parse(podatak[1]);
            var z = int.Parse(podatak[2]);

            if (x > y && x > z)
            {
                hipotenuza = x;
                kateta1 = y;
                kateta2 = z;
            }
            if (y > x && y > z)
            {
                hipotenuza = y;
                kateta1 = x;
                kateta2 = z;
            }
            if (z > y && z > x)
            {
                hipotenuza = z;
                kateta1 = y;
                kateta2 = x;
            }

            rez = kateta1 * kateta1 + kateta2 * kateta2;
            hipotenuza = hipotenuza * hipotenuza;

            if (hipotenuza == rez)
            {
                Console.Write("Ovo je pravokutni trokut");
            }
            else
            {
                Console.Write("Ovo nije pravokutni trokut");
            }

            Console.ReadKey();
        }
    }
}