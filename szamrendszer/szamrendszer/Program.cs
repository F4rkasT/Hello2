using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    class Szamrendszer
    {
        public Szamrendszer()
        {

        }

        public void getSzamr()
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Irj be egy számot!");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Milyen számrendszerbe váltsam");

            int szam = Convert.ToInt32(Console.ReadLine());

            string valtott = Convert.ToString(a, szam);

            Console.WriteLine(valtott);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamrendszer szamrendszer = new Szamrendszer();
            szamrendszer.getSzamr();
            Console.ReadKey();
        }
    }
}
