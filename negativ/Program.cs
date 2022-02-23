using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativ
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Adj meg egy nullától különböző számot: ");
            int szám1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik nullától különböző számot: ");
            int szám2 = Convert.ToInt32(Console.ReadLine());


            if (szám1 > 0 && szám2 > 0)
            {
                Console.WriteLine("A két szám közül egyik sem negatív");
            }
            else if (szám1 < 0 && szám2 < 0)
            {
                Console.WriteLine("Mind a két szám negatív");
            }
            else if (szám1 > 0 && szám2 < 0)
            {
                Console.WriteLine("A két szám közül a második negatív");
            }
            else if (szám1 < 0 && szám2 > 0)
            {
                Console.WriteLine("A két szám közül az első negatív");
            }
            Console.ReadKey();
        }
    }
}
