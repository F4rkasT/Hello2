using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool ism = true;
            Console.WriteLine("Adjon meg egy számot:");
            while (ism)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    ism = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Számot!!!!!");
                    ism = true;
                }
            }

            Console.ReadKey();
        }
    }
}