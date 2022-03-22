using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hőmérséklet
{
    class Program
    {
        private int[] hó;
        private string[] évszakok = new string[]{"Tél", "Tavasz", "Nyár", "Ősz"};
        private string évszak, hónap;
        private string[] Hónapok = new string[] { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };
        private Random rnd = new Random();

        static void datum()
        {
            switch (Console.ReadLine())
            {
                case "Január";

                    évszak = évszakok[0];
                    hónap = hónapok[0];
                switch ()
                {

                }
                break;
            }
        }
        static void Main(string[] args)
        {
         

        }
    }
}
