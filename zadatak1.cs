using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitZadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string niz;
            string nizu;

            Console.WriteLine("Upisi neki niz znakova --> ");
            niz = Convert.ToString(Console.ReadLine());

            nizu = (niz.Replace((" "), ("_")));

            Console.WriteLine(nizu);

            Console.ReadKey();
        }
    }
}
