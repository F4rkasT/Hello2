using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace könyv
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a", k2;
            int k = 0;
            while (a !="")
            {
                Console.Write("Add meg a könyv címét: ");
                k2 = Console.ReadLine();
                Console.WriteLine("Add meg a könyv oldalainak számát");
                k = Convert.ToInt32(Console.ReadLine());
                if(k < 150)
                {
                    Console.WriteLine("A(z) {0} rövid terjedelmű könyv", k2);
                }
                else if (k > 150)
                {
                    Console.WriteLine("A(z) {0} Hosszú terjedelmű könyv", k2);
                }
                else
                {
                    Console.WriteLine("Baj van");
                }
                Console.WriteLine("Ha nem szertnél több könyvet megnézni nyomj meg egy gombot");
            }
        }
    }
}
