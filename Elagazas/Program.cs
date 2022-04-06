using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazas
{
    class Elagazodas
    {
        public Elagazodas() { }
        Random rnd = new Random();
        public void elagaz()
        {
            int[] list = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = rnd.Next(10, 100);
            }
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i]%2 == 0)
                {
                    Console.WriteLine(list[i]);
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elagazodas Elagazodas = new Elagazodas();
            Elagazodas.elagaz();
            Console.ReadKey();
        }
    }
}
