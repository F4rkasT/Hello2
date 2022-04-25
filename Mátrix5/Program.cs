using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrix5
{
    class Program
    {
        public static void k(int[,] tömb)
        {
            for (int i = 0; i < tömb.GetLength(0); i++)
            {
                for (int j = 0; j < tömb.GetLength(1); j++)
                {
                    Console.Write(tömb[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int sor = 0;
            int oszlop = 0;
            string folyt = "igen";

            Console.WriteLine("Hány soros legyen a Mátrix?");
            sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hány oszlopos legyen?");
            oszlop = Convert.ToInt32(Console.ReadLine());
            int[,] Mátrix = new int[sor, oszlop];
            while (folyt == "igen")
            {
                Console.WriteLine("Vesszővel elválasztva adja meg a sort és oszlopot");

                string a = Console.ReadLine();
                string[] b = a.Split(',');
                sor = Convert.ToInt32(b[0]);
                oszlop = Convert.ToInt32(b[1]);
                int c = Convert.ToInt32(Math.Round(Convert.ToDouble(b[2])));

                if (Mátrix[sor, oszlop] == 0)
                {
                    Mátrix[sor, oszlop] = c;
                }
                else
                {
                    Console.WriteLine("Foglalt");
                }
                Console.WriteLine("Folytatod még?");
                folyt = Console.ReadLine();
                for (int i = 0; i < Mátrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Mátrix.GetLength(1); j++)
                    {
                        if (Mátrix[i, j] == 0)
                        {
                            Mátrix[i, j] = -1;
                        }
                    }
                }
            }
            k(Mátrix);
            Console.ReadKey();
        }
	}
}
