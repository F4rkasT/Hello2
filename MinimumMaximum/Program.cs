using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumMaximum
{
    public class MyClass
    {
        int min = 1000; 
        int max = 0;
        int minInd = 0; 
        int maxInd = 0; 
        int i; 

        int[] tomb = new int[100]; 
        Random veletlen = new Random();
        public MyClass()
        {
            feltoltes();
        }
        public MyClass(int a)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i + 1;
            }

        }
        private void feltoltes()
        {
            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = veletlen.Next(0, 10000);
            }
        }
        public void kaka()
        {
            for (i = 0; i < tomb.Length; i++)
            {
                
                if (tomb[i] < min)
                {
                    min = tomb[i];
                    minInd = i;
                }
                else if (tomb[i] > max)
                {
                    max = tomb[i];
                    maxInd = i;
                }
            }
            Console.WriteLine("A minimum szám: {0}, helye: {1} || A maximum szám: {2}, helye: {3}", min, minInd, max, maxInd);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1);

            myClass.kaka();
            Console.ReadKey();
        }

    }
}