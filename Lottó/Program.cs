using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottó
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Random rnd = new Random();
            Console.WriteLine("Ötös lottó");
            szam = Convert.ToInt32(Console.ReadLine());

            int[] tomb = new int[5];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 91);
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] == tomb[i])
                    {
                        --i;
                        break;
                    }
                }
            }
            Console.WriteLine("Nyerőszámok:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}", tomb[i]);
            }
            Console.ReadKey();
        }
    }
}
