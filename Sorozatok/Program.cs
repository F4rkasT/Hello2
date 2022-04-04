using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorozatok
{
    class Sorozatok
    {
        public Sorozatok() { }

        public void szamol()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            Console.WriteLine("csá");
            Console.WriteLine("4 elemet kérek");


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if (a - b == c - d & a - c == b - d)
            {
                Console.WriteLine("Ez egy Számtani");
            }
            else
            {
                if (a / b == c / d & b / c == b / d)
                {
                    Console.WriteLine("Ez egy Mértani");
                }
            }
            Console.ReadKey();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sorozatok sor = new Sorozatok();
            sor.szamol();
            Console.ReadKey();
        }
    }
}
