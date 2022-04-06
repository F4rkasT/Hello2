using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class List
    {
        Random rnd = new Random();
        public List() { }
        public void lista()
        {
            Console.WriteLine("Mennyi legyen a listába?");
            int[] list = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = rnd.Next(10, 100);
            }
            Console.WriteLine("A számok:");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("{1}", i, list[i]);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.lista();
            Console.ReadKey();
        }
    }
}
