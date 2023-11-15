using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitZadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Upiši jedan prirodan i jedan decimalan broj odvojen razmakom: ");

            var znakovi = Console.ReadLine();
            var podatak = znakovi.Split(' ');


            double avg = 0;
            double niz = 0, niz2 = 0;
            double raz = 99999, raz2 = 99999;
            double min = 999999, min2 = 999999;
            double nes = 0;
          
            

            for (i = 0; i < podatak.Length; i++)
            {
                niz = double.Parse(podatak[i]);
                avg = avg + niz;


            }
                avg = avg / podatak.Length;

            for (i = 0; i < podatak.Length; i++)
            {
                nes = double.Parse(podatak[i]);

                if (nes < avg) {

                    if (raz < min)
                    {
                        raz = avg - nes;
                    }

                    min = raz;
                }
            }
            for (i = 0; i < podatak.Length; i++)
            {
                nes = double.Parse(podatak[i]);

                if (nes > avg)
                {

                    if (raz2 < min2)
                    {
                        raz2 = avg - nes;
                    }

                    min2 = raz2;
                }
            }


            //BAS I NE RADI NESTO...

            Console.WriteLine("OVO JE KOLKO JEDNO ODSTUPA --> "+ min);
            Console.WriteLine("OVO JE KOLKO DRUGO ODSTUPA --> " + min2);

            Console.WriteLine("OVO JE AVG --> " + avg);

            Console.ReadKey();
        }
    }
}
