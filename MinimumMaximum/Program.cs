using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumMaximum
{
    public class MinMax
    {
        public MinMax() { }

        int min = 1000;
        int max = 0;
        int minInd = 0;
        int maxInd = 0;
        int i;

        int[] tomb = new int[20];
        Random rnd = new Random();

        public int mines()
        {
            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(0, 1000);
            }
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
            Console.WriteLine("A minimum szám: {0}, helye: {1}", min, minInd);
            Console.WriteLine("A maximum szám: {0}, helye: {1}", max, maxInd);
            return min;
        }

        public int maxos()
        {
            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(0, 1000);
            }
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
            Console.WriteLine("A minimum szám: {0}, helye: {1}", min, minInd);
            Console.WriteLine("A maximum szám: {0}, helye: {1}", max, maxInd);
            return max;
        }

        public int mini()
        {
            int[] tomb = new int[] { 4, 7, 3, 11, 18, 32, 40, 83, 56, 20, 72, 71, 8, 99, 106, 156, 120, 180, 177, 141, 199, 111, 54, 85, 24 };

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
            Console.WriteLine("A minimum szám: {0}, helye: {1}", min, minInd);
            return min;
        }

        public int maxi()
        {
            int[] tomb = new int[] { 4, 7, 3, 11, 18, 32, 40, 83, 56, 20, 72, 71, 8, 99, 106, 156, 120, 180, 177, 141, 199, 111, 54, 85, 24 };

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
            Console.WriteLine("A maximum szám: {0}, helye: {1}", max, maxInd);
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MinMax osztaly = new MinMax();
            osztaly.mini();
            osztaly.maxi();
            Console.ReadKey();
        }
    }
}