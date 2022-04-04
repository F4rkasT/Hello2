using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bináris
{
    class Binaris
    {
        public Binaris() { }

        public void szamol()
        {   
            int b = 0;
            string a;
            Console.WriteLine("Bináris számot kérek:");
            a = Console.ReadLine();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '1')
                {
                    b++;
                }
            }
            Console.WriteLine("Egyesek: {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Binaris c = new Binaris();
            c.szamol();
            Console.ReadKey();
        }
    }
}
