using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    class Szamrendszer
    {
        public Szamrendszer() { }

        public void Szamr()
        {
            Console.WriteLine("Helló");

            Console.WriteLine("Irj be egy számot");

            int beirt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Milyen számrendszerbe váltsam?");

            int szamr = Convert.ToInt32(Console.ReadLine());

            string valtott = Convert.ToString(beirt, szamr);

            Console.WriteLine(valtott);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamrendszer szamrend = new Szamrendszer();
            szamrend.Szamr();
            Console.ReadKey();
        }
    }
}