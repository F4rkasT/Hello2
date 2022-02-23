using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Páros_páratlan
{
    class Program
    {
        static void Main(string[] args)
        {
            int páros = 0;
            int páratlan = 0;
            int páratlanok = 0;
            int i = 0;
            int b = 0;
            Random random = new Random();
            int N = random.Next(5, 10);
            Console.Write("Irjon be számokat: ");

            while (N > i)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b % 2 == 0)
                {
                    páros++;
                }
                else if (b %2 == 1)
                {
                    páratlan++;
                    páratlanok = páratlanok + páratlan;
                }
                i++;
            }
            Console.WriteLine("páros {0} és páratlan számok {1} darabszámát, és a páratlanszámok összegét {2} a megadott N-ig", páros, páratlan, páratlanok);
            Console.ReadKey();
        }
    }
}
