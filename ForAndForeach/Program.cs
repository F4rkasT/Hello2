using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeach
{
    class ForAndForeach
    {
        public ForAndForeach() { }
            int[] tomb = new int[40];
            Random rnd = new Random();
            public void toltes()
            {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1, 1000);
            }
            }
        public void hoppa()
        {
            Console.WriteLine("for-ral");
            for (int i = 0; i < tomb.Length; i++)
            {

            }
        }
    }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
