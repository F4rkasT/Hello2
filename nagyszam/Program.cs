using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagyszam
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "egyik";
            string b = "másik";
            int x = String.Compare(a, b);
            if (x == 0)
            {
                Console.WriteLine("A két szám egyenlő");
            }
            else if (x < 0)
            {
                Console.WriteLine("Az 'a' a kisebb");
            }
            else
            {
                Console.WriteLine("Az 'a' a nagyobb");
            }
        }
    }
}
