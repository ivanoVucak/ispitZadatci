using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitZadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prvi;
            string drugi;

            Console.WriteLine("Unesi prvi string --> ");
            prvi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Unesi drugi string --> ");
            drugi = Convert.ToString(Console.ReadLine());

        
            Console.WriteLine(string.Compare(prvi, drugi));
            //NISAM STIGO

            Console.ReadKey();
        }
    }
}
