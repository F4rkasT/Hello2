using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számkitaláló
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pc_random = random.Next(1, 100);

            Console.WriteLine("Tippeljél");
            Console.WriteLine("A számító gondol");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    goto PLAYER;
                case '2':
                    goto COMPUTER;
            }
        PLAYER: goto END;
        COMPUTER: goto END;

        END:
            Console.WriteLine("\nAkarsz még játszani? i/n");
            switch (Console.ReadKey(true).KeyChar)
            {
                case
            }
        }
    }
}
