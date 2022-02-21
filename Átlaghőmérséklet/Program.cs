using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghőmérséklet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tömb = new int[12, 30];
            Random random = new Random();

            // tömb feltöltése random elemekkel
            for (int i = 0; i < tömb.GetLength(0); i++)
            {
                for (int j = 0; j < tömb.GetLength(1); j++)
                {
                    tömb[i, j] = random.Next(-10, 40);
                }
            }

            int min = Int32.MaxValue;
            int min_i = -1;
            int max = Int32.MinValue;
            int max_i = -1;
            int min_j = -1;
            int max_j = -1;

            //min max
            for (int i = 0; i < tömb.GetLength(0); i++)
            {
                for (int j = 0; j < tömb.GetLength(1); j++)
                {
                    if (min > tömb[i, j])
                    {
                        min = tömb[i, j];
                        min_i = i;
                        min_j = j;
                    }
                    if (max < tömb[i, j])
                    {
                        max = tömb[i, j];
                        max_i = i;
                        max_j = j;
                    }
              

                }
              
            }
            Console.WriteLine("minimum index (i): {0}", min_i);
            Console.WriteLine("maximum index (i):{0}", max_i);
            Console.WriteLine("minimum index (j):{0}", min_j);
            Console.WriteLine("maximum index (j):{0}", max_j);
            Console.WriteLine("minimum:{0}", min);
            Console.WriteLine("maximum:{0}", max);
            //átlagszámos
            int hom_sum = 0;
            int index = -1;
            int[] hónap_átlag = new int[12];
            for (int i = 0; i < tömb.GetLength(0); i++)
            {
                index++;

                for (int j = 0; j < tömb.GetLength(1); j++)
                {
                    hom_sum = tömb[i, j] + hom_sum;
                        
                }
                hónap_átlag[index] = hom_sum;
                hom_sum = 0;

                int napok = 0;
                
                Console.ReadKey();
                }
            }
        }
    }