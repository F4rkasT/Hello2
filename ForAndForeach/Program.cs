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
        private int[] tomb = new int[40];
        private Random rnd = new Random();
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
                Console.WriteLine(tomb[i]);
            }
        }
        public void ForE()
        {
            Console.WriteLine("Foreach-el");

             foreach (var index in tomb)
            {
                Console.WriteLine("Foreach");
            }
    }
        
        
        class Program
        {
            static void Main(string[] args)
            {
                ForAndForeach a = new ForAndForeach();
                a.toltes();
                a.hoppa();
                a.ForE();
                Console.ReadKey();
            }
        }
    }
}
