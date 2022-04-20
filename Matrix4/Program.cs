using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sorok;
            int oszlopok;
            int[,] tomb;
            string[] szöveg;
            int a;
            int b;
            int c;
            Console.WriteLine("Add meg a sorok számét");
            sorok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg az oszlopok számát");
            oszlopok = Convert.ToInt32(Console.ReadLine());
            tomb = new int[sorok, oszlopok];
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    tomb[i, j] = 0;
                }
            }
            szöveg = Console.ReadLine().Split(',');
            a = Convert.ToInt32(szöveg[0]);
            b = Convert.ToInt32(szöveg[1]);
            c = Convert.ToInt32(szöveg[2]);
            if (tomb [a,b] == 0)
            {
                tomb[a, b] = c;
            }
            else
            {
                Console.WriteLine("M ár van érték ezen az indexen");
            }
        }
    }
}
