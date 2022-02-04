using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtable3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Parancssori paraméterek száma lehet: 0, 1, 2*/
            int szam = 0;

            // Ha kapok számot a parancssorból
            if (args.Length > 0)
            {
                // Akkor átalakítom
                szam = int.Parse(args[0]);
            }
            else
            {
                Random rnd = new Random();
                szam = rnd.Next(1, 50);
            }

            Console.WriteLine(szam * 2);
            Console.ReadKey();
        }
    }