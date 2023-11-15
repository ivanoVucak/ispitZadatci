using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitZadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int niz = 0;
            int p1 = 1, p2 = 0;

            Console.Write("Unesi neki broj --> ");
            n = Convert.ToInt16(Console.ReadLine());

            if (n == 0)
            {
                Console.Write("Taj clan fibonaccijevog niza je --> 0");
            }
            if (n == 1)
            {
                Console.Write("Taj clan fibonaccijevog niza je --> 1");
            }
            if (n > 1) {
                for (int i = 0; i < n; i++) {
                    niz = p1 + p2;
                    p2 = p1;
                    p1 = niz;
                }
                Console.WriteLine("Taj clan fibonaccijevog niza je --> " + niz);
            }
            Console.ReadKey();
        }
    }
}
