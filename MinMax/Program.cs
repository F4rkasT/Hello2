using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(Int32.MinValue, Int32.MaxValue);
            }
            


            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            Console.ReadKey();

            int min = Int32.MaxValue;
            int min_i = -1;
            int max = Int32.MinValue;
            int max_i = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    min_i = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if ( max < arr[i])
                {
                    max = arr[i];
                    max_i = i;
                }
            }
        }
    }
}
