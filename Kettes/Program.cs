using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Kettes
    {
        private int szam;
        private string valtott;
        public Kettes() { }
        public void valto()
        {
            Console.WriteLine("adja meg a számot");
            szam = Convert.ToInt32(Console.ReadLine());
            valtott = Convert.ToString(szam, 2);
            Console.WriteLine("A szám");
            Console.Write(valtott);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Kettes a = new Kettes();
                a.valto();
                Console.ReadKey();
            }
        }
    }
}
